namespace ConnectApp.redux.actions {
    public class FetchNotificationsAction : RequestAction {
        public int pageNumber = 0;
    }

    public class FetchNotificationsSuccessAction : BaseAction {
    }
}