using System;
using System.Windows.Forms;
using Ninject;
using POS.BLL;
using POS.BLL.Security;
using POS.Shared;

namespace POS.Security
{
    public partial class LoginForm : Form
    {
        private readonly IUserInformationService _userInformationService;

        public LoginForm()
        {
            InitializeComponent();
            IKernel kernel = BootStrapper.Initialize();
            _userInformationService = kernel.GetService(typeof(UserInformationService)) as UserInformationService;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var home = new BaseForm();
            home.Closed += (o, args) => Close();
            home.Show();

            //try
            //{
            //    var userInformation = _userInformationService.GetUserDetails(null, txtUsername.Text.Trim());
            //    if (userInformation == null)
            //    {
            //        MessageBox.Show(@"Username or password is incorrect. Please enter your valid credentials.");
            //        return;
            //    }

            //    if (Authenticator.ValidatePassword(txtPassword.Text.Trim(), userInformation.Password))
            //    {
            //        if (!userInformation.IsActive || userInformation.IsLocked)
            //        {
            //            MessageBox.Show(@"User is not active now. Please contact with your system administrator.");
            //        }

            //        if (userInformation.IsPasswordChanged)
            //        {
            //            LoginInformation.UserInformation = userInformation;

            //            Hide();
            //            var home = new HomeForm();
            //            home.Closed += (o, args) => Close();
            //            home.Show();
                       
            //            MessageBox.Show(@"Login Successful.");
            //        }
            //    }
            //}
            //catch (Exception exception)
            //{
            //    if (exception.Message.Contains("The underlying provider failed on Open"))
            //    {
            //        MessageBox.Show(@"Failed to connect database server. Please contact with your system administrator.");
            //    }
            //}
        }
    }
}
