using System;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class FBService
    {
        private static FacebookWrapper.LoginResult s_LoginResult;
        private static User s_User = null;
        public static User User
        {
            get {
                if (s_User == null)
                {
                    login();
                }

                return s_User;
            }
        }

        static FBService()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private static void login()
        {
            try
            {
                s_LoginResult = FacebookService.Login(
                    "1380984126104335",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
                );

                //string accessToken = "";
                //s_LoginResult = FacebookService.Connect(accessToken);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

            if (string.IsNullOrEmpty(s_LoginResult.ErrorMessage))
            {
                s_User = s_LoginResult.LoggedInUser;
            }
        }

        public static void Logout()
        {
            s_LoginResult = null;
            s_User = null;
        }
    }
}
