using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleSharp.TL;
using TeleSharp.TL.Messages;

using TLSharp.Core;
using TLSharp.Core.Utils;

namespace Telegram
{
    public partial class FrmMain : Form
    {
        private static readonly FileSessionStore Store = new FileSessionStore();

        private const string AccountsPath = "Accounts";
        private string hash;
        private TelegramClient client;
        private string NumberToSendMessage;
        List<UserMessage> _resultUserMessages = new List<UserMessage>();
        private class UserMessage
        {
            public UserMessage()
            {
            }

            public int CreateDateTime { get; set; }
            public int? FromId { get; set; }
            public string Message { get; set; }

            public TLAbsMessageMedia Media { get; set; }

        }

        private TelegramClient NewClient()
        {
            try
            {
                return new TelegramClient(35699, "c5faabe85e286bbb3eac32df78b34517");
            }
            catch (MissingApiConfigurationException ex)
            {
                throw new Exception($"Please add your API settings to the `app.config` file. (More info: {MissingApiConfigurationException.InfoUrl})",
                                    ex);
            }
        }




        public FrmMain()
        {
            InitializeComponent();

            if (!Directory.Exists(AccountsPath))
                Directory.CreateDirectory(AccountsPath);

        }

        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            NumberToSendMessage = tbPhoneNumber.Text;
            if (string.IsNullOrWhiteSpace(NumberToSendMessage))
                return;
            // this is because the contacts in the address come without the "+" prefix
            var normalizedNumber = NumberToSendMessage.StartsWith("+") ?
                NumberToSendMessage.Substring(1, NumberToSendMessage.Length - 1) :
                NumberToSendMessage;



            client = NewClient();

            await client.ConnectAsync();

            hash = await client.SendCodeRequestAsync(normalizedNumber);
            tbPhoneNumber.Enabled = false;
            btnSendCode.Enabled = false;
            tbVerficationCode.Enabled = true;
            btnLoginNew.Enabled = true;



        }

        private async void btnLoginNew_Click(object sender, EventArgs e)
        {
            var code = tbVerficationCode.Text; // you can change code in debugger too

            if (String.IsNullOrWhiteSpace(code))
            {
                throw new Exception("CodeToAuthenticate is empty in the app.config file, fill it with the code you just got now by SMS/Telegram");
            }

            TLUser user = null;
            try
            {
                user = await client.MakeAuthAsync(tbPhoneNumber.Text, hash, code);
            }
            catch (CloudPasswordNeededException ex)
            {
                var password = await client.GetPasswordSetting();
                var password_str = "";

                user = await client.MakeAuthWithPasswordAsync(password, password_str);


            }
            catch (InvalidPhoneCodeException ex)
            {
                throw new Exception("CodeToAuthenticate is wrong in the app.config file, fill it with the code you just got now by SMS/Telegram",
                                    ex);
            }

            try
            {

                var photo = ((TLUserProfilePhoto)user.photo);
                var photoLocation = (TLFileLocation)photo.photo_small;
                var resFile = await client.GetFile(new TLInputFileLocation()
                {
                    local_id = photoLocation.local_id,
                    secret = photoLocation.secret,
                    volume_id = photoLocation.volume_id
                }, 100000, 0);


                Bitmap image;
                using (MemoryStream stream = new MemoryStream(resFile.bytes))
                {
                    image = new Bitmap(stream);
                }
                pbSelfPicture.Image = image;
            }
            catch (Exception)
            {

            }



        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {

                string sessionPath = Path.Combine(Application.StartupPath, @"session.dat");
                Store.Load(sessionPath);
                client = new TelegramClient(35699, "c5faabe85e286bbb3eac32df78b34517", Store, sessionPath);

                bool connectResult = await client.ConnectAsync();

                if (connectResult == false)
                    this.Text = this.Text + "  Failed to login";

                else
                {
                    this.Text = this.Text + "  Login success";

                    try
                    {
                        var client = NewClient();

                        await client.ConnectAsync();

                        var result = await client.GetContactsAsync();

                        //find recipient in contacts
                        var user = result.users.lists
                            .Where(x => x.GetType() == typeof(TLUser))
                            .Cast<TLUser>()
                            .FirstOrDefault(x => x.self);

                        var photo = ((TLUserProfilePhoto)user.photo);
                        var photoLocation = (TLFileLocation)photo.photo_small;
                        var resFile = await client.GetFile(new TLInputFileLocation()
                        {
                            local_id = photoLocation.local_id,
                            secret = photoLocation.secret,
                            volume_id = photoLocation.volume_id
                        }, 100000, 0);


                        Bitmap image;
                        using (MemoryStream stream = new MemoryStream(resFile.bytes))
                        {
                            image = new Bitmap(stream);


                        }
                        pbSelfPicture.Image = image;
                    }
                    catch (Exception)
                    {

                    }







                    // pictureBox1.Image = ByteToImage( resFile.bytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private async void SendTextNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumber.Text))
                return;
            NumberToSendMessage = tbNumber.Text;

            var normalizedNumber = NumberToSendMessage.StartsWith("+") ?
                NumberToSendMessage.Substring(1, NumberToSendMessage.Length - 1) :
                NumberToSendMessage;

            var client = NewClient();

            await client.ConnectAsync();

            var result = await client.GetContactsAsync();

            var user = result.users.lists
                .OfType<TLUser>()
                .FirstOrDefault(x => x.phone == normalizedNumber);

            if (user == null)
            {
                throw new System.Exception("Number was not found in Contacts List of user: " + NumberToSendMessage);
            }

            await client.SendTypingAsync(new TLInputPeerUser() { user_id = user.id });
            Thread.Sleep(3000);
            await client.SendMessageAsync(new TLInputPeerUser() { user_id = user.id }, tbMessage.Text);

        }

        private async void btnChannelSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbChannelId.Text))
                return;
            var client = NewClient();
            await client.ConnectAsync();

            var dialogs = (TLDialogsSlice)await client.GetUserDialogsAsync();
            var chat = dialogs.chats.lists
                .OfType<TLChannel>()
                .FirstOrDefault(c => c.username == tbChannelId.Text);

            await client.SendMessageAsync(new TLInputPeerChannel() { channel_id = chat.id, access_hash = chat.access_hash.Value }, tbChannelMessage.Text);
        }





        private async void SendFileNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumber.Text))
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            openFileDialog.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                var onlyfilename = Path.GetFileName(openFileDialog.FileName);
                var filename = openFileDialog.FileName;




                var client = NewClient();

                await client.ConnectAsync();

                var result = await client.GetContactsAsync();
                NumberToSendMessage = tbNumber.Text;
                var user = result.users.lists
                    .OfType<TLUser>()
                    .FirstOrDefault(x => x.phone == NumberToSendMessage);

                var fileResult = (TLInputFile)await client.UploadFile(onlyfilename, new StreamReader(filename));
                await client.SendUploadedPhoto(new TLInputPeerUser() { user_id = user.id }, fileResult, tbMessage.Text);
            }

        }

        private async void GetHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string path1 = Path.Combine(Application.StartupPath, "Download");

                string path2 = Path.Combine(Application.StartupPath, "Download", tbNumber.Text);

                if (!Directory.Exists(path1))
                {
                    Directory.CreateDirectory(path1);
                }
                if (!Directory.Exists(path2))
                {
                    Directory.CreateDirectory(path2);
                }

                TxtHistory.Clear();
                _resultUserMessages.Clear();
                NumberToSendMessage = tbNumber.Text;

                if (string.IsNullOrWhiteSpace(NumberToSendMessage))
                    return;
                // this is because the contacts in the address come without the "+" prefix
                var normalizedNumber = NumberToSendMessage.StartsWith("+") ?
                    NumberToSendMessage.Substring(1, NumberToSendMessage.Length - 1) :
                    NumberToSendMessage;

                var client = NewClient();

                await client.ConnectAsync();

                var result = await client.GetContactsAsync();

                var user = result.users.lists
                    .OfType<TLUser>()
                    .FirstOrDefault(x => x.phone == normalizedNumber);

                if (user == null)
                {
                    throw new System.Exception("Number was not found in Contacts List of user: " + NumberToSendMessage);
                }

                TLAbsMessages tlAbsMessages =
                    await client.GetHistoryAsync(new TLInputPeerUser() { user_id = user.id }, 0, -1,int.Parse( nudCount.Value.ToString()));
                try
                {
                    var tlMessages = (TLMessages)tlAbsMessages;

                    for (var index = 0; index < tlMessages.messages.lists.Count; index++)
                    {
                        var tlAbsMessage = tlMessages.messages.lists[index];
                        var message = (TLMessage)tlAbsMessage;
                        _resultUserMessages.Add(new UserMessage()
                        {
                            FromId = message.from_id,
                            Message = message.message,
                            CreateDateTime = message.date,
                            Media = message.media
                        });
                    }
                }
                catch (Exception)
                {
                    var tlMessagesslice = (TLMessagesSlice)tlAbsMessages;
                    for (var index = 0; index < tlMessagesslice.messages.lists.Count; index++)
                    {
                        var tlAbsMessage = tlMessagesslice.messages.lists[index];
                        var message = (TLMessage)tlAbsMessage;
                        _resultUserMessages.Add(new UserMessage()
                        {
                            FromId = message.from_id,
                            Message = message.message,
                            CreateDateTime = message.date,
                            Media = message.media
                        });
                    }


                }


                foreach (var item in _resultUserMessages.OrderBy(c => c.CreateDateTime))
                {
                    if (item.Media != null)
                    {


                        switch (item.Media.GetType().ToString())
                        {

                            case "TeleSharp.TL.TLMessageMediaDocument":
                                {
                                    var media = (TLMessageMediaDocument)item.Media;
                                    var document = (TLDocument)media.document;
                                    TLDocumentAttributeFilename filename = null;
                                    try
                                    {
                                        var count = document.attributes.lists.Count;

                                        switch (count)
                                        {
                                            case 1:
                                                {
                                                    filename = (TLDocumentAttributeFilename)(document.attributes.lists[0]);

                                                    break;
                                                }
                                            case 2:
                                                {
                                                    filename = (TLDocumentAttributeFilename)(document.attributes.lists[1]);

                                                    break;
                                                }
                                            case 3:
                                                {
                                                    try
                                                    {
                                                        filename = (TLDocumentAttributeFilename)(document.attributes.lists[2]);

                                                    }
                                                    catch
                                                    {

                                                        filename = (TLDocumentAttributeFilename)(document.attributes.lists[1]);
                                                        TxtHistory.Text += "==>" + item.FromId + " : " + "@Gif \n";
                                                    }

                                                    break;
                                                }

                                            default:
                                                break;
                                        }


                                    }
                                    catch (Exception)
                                    {

                                    }


                                    var resFile = await client.GetFile(

                                        new TLInputDocumentFileLocation()
                                        {
                                            access_hash = document.access_hash,
                                            id = document.id,
                                            version = document.version,

                                        },
                                        document.size);

                                    SaveData(resFile.bytes, filename.file_name);
                                    break;
                                }



                            case "TeleSharp.TL.TLMessageMediaPhoto":
                                {
                                    var media = (TLMessageMediaPhoto)item.Media;
                                    var caption = media.caption;
                                    var photo = (TLPhoto)media.photo;
                                    var count = photo.sizes.lists.Count();
                                    var photosize = (TLPhotoSize)photo.sizes.lists[count - 1];

                                    var photoLocation = (TLFileLocation)photosize.location;
                                    var resFile = await client.GetFile(new TLInputFileLocation()
                                    {
                                        local_id = photoLocation.local_id,
                                        secret = photoLocation.secret,
                                        volume_id = photoLocation.volume_id
                                    }, photosize.size, 0);


                                    string filenamet = "";
                                    Guid name;
                                    var imageType = resFile.type;


                                    switch (imageType.Constructor)
                                    {
                                        case 8322574:
                                            {
                                                name = Guid.NewGuid();
                                                filenamet = name.ToString() + ".jpg";
                                                break;
                                            }
                                        case -891180321:
                                            {
                                                name = Guid.NewGuid();
                                                filenamet = name.ToString() + ".gif";
                                                break;
                                            }
                                        case 172975040:
                                            {
                                                name = Guid.NewGuid();
                                                filenamet = name.ToString() + ".png";
                                                break;
                                            }
                                        default:
                                            {
                                                name = Guid.NewGuid();
                                                filenamet = name.ToString();
                                                break;
                                            }
                                    }

                                    SaveData(resFile.bytes, filenamet);
                                    break;
                                }
                            default:
                                {

                                    break;
                                }
                        }








                    }
                    else
                    {




                        TxtHistory.Text += "==>" + item.FromId + " : " + item.Message + Environment.NewLine;

                        TxtHistory.AppendText("\n");

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void LoadALlNumber(string searchtext)
        {
            try
            {
                lvList.Items.Clear();
                var client = NewClient();

                await client.ConnectAsync();
                var result = await client.GetContactsAsync();

                foreach (var item in result.contacts.lists)
                {




                    var user = result.users.lists
                               .OfType<TLUser>()
                               .FirstOrDefault(x => x.id == item.user_id);

                    if (user.phone.ToString().Contains(searchtext))
                    {

                        ListViewItem list = new ListViewItem(user.username != null ? user.username : " ");

                        list.SubItems.Add(user.phone);
                        list.SubItems.Add(user.first_name != null ? user.first_name : " ");

                        list.SubItems.Add(user.last_name != null ? user.last_name : " ");

                        lvList.Items.AddRange(new ListViewItem[] { list });
                    }
                }
            }
            catch { }




        }

        private async void lvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbNumber.Text = lvList.SelectedItems[0].SubItems[1].Text;

                try
                {
                    var client = NewClient();

                    await client.ConnectAsync();

                    var result = await client.GetContactsAsync();

                    //find recipient in contacts
                    var user = result.users.lists
                        .Where(x => x.GetType() == typeof(TLUser))
                        .Cast<TLUser>()
                        .FirstOrDefault(x => x.phone == tbNumber.Text);

                    lblID.Text = user.id.ToString();

                    var photo = ((TLUserProfilePhoto)user.photo);
                    var photoLocation = (TLFileLocation)photo.photo_small;
                    var resFile = await client.GetFile(new TLInputFileLocation()
                    {
                        local_id = photoLocation.local_id,
                        secret = photoLocation.secret,
                        volume_id = photoLocation.volume_id
                    }, 100000, 0);


                    Bitmap image;
                    using (MemoryStream stream = new MemoryStream(resFile.bytes))
                    {
                        image = new Bitmap(stream);
                    }
                    pbUserPicture.Image = image;
                }
                catch (Exception)
                {

                }



            }
            catch
            {

            }
        }

        public virtual async Task DownloadFileFromContactTest()
        {
            NumberToSendMessage = tbNumber.Text;
            var client = NewClient();

            await client.ConnectAsync();

            var result = await client.GetContactsAsync();

            var user = result.users.lists
                .OfType<TLUser>()
                .FirstOrDefault(x => x.phone == NumberToSendMessage);

            var inputPeer = new TLInputPeerUser() { user_id = user.id };
            var res = await client.SendRequestAsync<TLMessagesSlice>(new TLRequestGetHistory() { peer = inputPeer, limit = 1 });
            var document = res.messages.lists
                .OfType<TLMessage>()
                .Where(m => m.media != null)
                .Select(m => m.media)
                .OfType<TLMessageMediaDocument>()
                .Select(md => md.document)
                .OfType<TLDocument>()
                .FirstOrDefault();

            var resFile = await client.GetFile(
                new TLInputDocumentFileLocation()
                {
                    access_hash = document.access_hash,
                    id = document.id,
                    version = document.version
                },
                document.size);

            bool sss = resFile.bytes.Length > 0;


        }

        protected bool SaveData(byte[] Data, string filename)
        {
            BinaryWriter Writer = null;
            string Name = Path.Combine(Application.StartupPath, "Download", tbNumber.Text, filename);

            try
            {
                // Create a new stream to write to the file
                Writer = new BinaryWriter(File.OpenWrite(Name));

                // Writer raw data                
                Writer.Write(Data);
                Writer.Flush();
                Writer.Close();
            }
            catch
            {
                //...
                return false;
            }

            return true;
        }

        private void btnLoadContact_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() =>
                    lvList.Invoke(new MethodInvoker(delegate
                    {
                        LoadALlNumber(tbSerch.Text);

                    })))
                { IsBackground = true }.Start();
            }
            catch
            {
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() =>
                    lvList.Invoke(new MethodInvoker(delegate
                    {
                        LoadALlNumber(tbSerch.Text);
                    })))
                { IsBackground = true }.Start();
            }
            catch
            {
            }
        }
    }
}