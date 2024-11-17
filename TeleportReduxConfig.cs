namespace TeleportReduxConfig;
public static class TeleportReduxConfiger
{
    internal static ConfigCategory Category;
    internal static KeybindConfigEntry InterfaceKey;

    public static void Init()
    {
        Category = ConfigSystem.CreateFileCategory("TeleportRedux", "TeleportRedux", "TeleportRedux.cfg");
        InterfaceKey = Category.CreateKeybindEntry("Open Interface", KeyCode.I.ToString(), "InterfaceKey", "Key to open the interface.");
        InterfaceKey.SetScope(needsPlayerControllable: true);
    }
}

