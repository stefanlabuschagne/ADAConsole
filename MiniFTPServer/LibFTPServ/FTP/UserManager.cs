using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace LibFTPServ.FTP
{
    /// <summary>
    /// A User management class
    /// </summary>
    public class UserManager
    {
        private List<FTPUser> _users;

        /// <summary>
        /// Creates a new instance of UserManager
        /// </summary>
        public UserManager()
        {
            _users = new List<FTPUser>();
        }

        /// <summary>
        /// Adds a user to the management system
        /// </summary>
        /// <param name="user">The user to be added</param>
        public void AddUser(FTPUser user)
        {
            _users.Add(user);
        }

        /// <summary>
        /// Removes a user from the management system
        /// </summary>
        /// <param name="user">The user to be removed</param>
        public void RemoveUser(FTPUser user)
        {
            _users.Remove(user);
        }

        /// <summary>
        /// Removes a user from the management system by the user's name
        /// </summary>
        /// <param name="name">The name of the user to be removed</param>
        public void RemoveUserbyName(string name)
        {
            var q = (from user in _users where user.Name == name select user).ToList();
            foreach (FTPUser u in q) _users.Remove(u);
        }

        /// <summary>
        /// Returns a user based on it's name
        /// </summary>
        /// <param name="name">The name of the user to get</param>
        /// <returns></returns>
        public FTPUser this[string name]
        {
            get
            {
                var q = from user in _users where user.Name == name select user;
                return q.FirstOrDefault();
            }
        }

        /// <summary>
        /// Gets the permissions associated to the user by the user's name
        /// </summary>
        /// <param name="name">the name of the user</param>
        /// <returns></returns>
        public FTPUserPermission GetPermissions(string name)
        {
            var q = from user in _users where user.Name == name select user.Permissions;
            return q.FirstOrDefault();
        }

        /// <summary>
        /// Gets the number of users in the management system
        /// </summary>
        public int Count
        {
            get
            {
                return _users.Count;
            }
        }

        /// <summary>
        /// serializes users to stream
        /// </summary>
        /// <param name="Target"></param>
        public void Serialize(Stream Target)
        {
            XmlSerializer xs = new XmlSerializer(typeof(FTPUser[]));
            xs.Serialize(Target, _users.ToArray());
        }

        /// <summary>
        /// Deserializes users from stream
        /// </summary>
        /// <param name="Source"></param>
        public void Deserialize(Stream Source)
        {
            XmlSerializer xs = new XmlSerializer(typeof(FTPUser[]));
            _users.AddRange((FTPUser[])xs.Deserialize(Source));
        }

        /// <summary>
        /// gets the user names
        /// </summary>
        public string[] UserNames
        {
            get
            {
                return (from user in _users select user.Name).ToArray();
            }
        }
    }
}
