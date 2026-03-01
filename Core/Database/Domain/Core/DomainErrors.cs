namespace Resources
{
    public static class DomainErrors
    {
        public static string DerivationErrorAtLeastOne => "{0} at least one";
        public static string DerivationErrorAtMostOne => "{0} at most one";
        public static string DerivationErrorConflict => "{0} is in conflict";
        public static string DerivationErrorEquals => "{0} are not equal";
        public static string DerivationErrorNotAllowed => "{0} is not allowed";
        public static string DerivationErrorRequired => "{0} is required";
        public static string DerivationErrorUnique => "{0} is not unique";
        public static string InvalidNewPassword => "New password does not meet complexity requirements";
        public static string InvalidPassword => "Invalid password.";
        public static string PermissionOnlyExecuteForMethodType => "only execute is allowed for method type";
        public static string PermissionOnlyReadForRoleOrAssociationType => "only read is allowed for a role or an association type";
        public static string PermissionOnlyWriteForRoleType => "only write is allowed for a role type";
    }
}
