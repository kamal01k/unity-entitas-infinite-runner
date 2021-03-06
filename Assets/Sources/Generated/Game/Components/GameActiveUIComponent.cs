//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ActiveUIComponent activeUI { get { return (ActiveUIComponent)GetComponent(GameComponentsLookup.ActiveUI); } }
    public bool hasActiveUI { get { return HasComponent(GameComponentsLookup.ActiveUI); } }

    public void AddActiveUI(bool newIsActive) {
        var index = GameComponentsLookup.ActiveUI;
        var component = CreateComponent<ActiveUIComponent>(index);
        component.isActive = newIsActive;
        AddComponent(index, component);
    }

    public void ReplaceActiveUI(bool newIsActive) {
        var index = GameComponentsLookup.ActiveUI;
        var component = CreateComponent<ActiveUIComponent>(index);
        component.isActive = newIsActive;
        ReplaceComponent(index, component);
    }

    public void RemoveActiveUI() {
        RemoveComponent(GameComponentsLookup.ActiveUI);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherActiveUI;

    public static Entitas.IMatcher<GameEntity> ActiveUI {
        get {
            if (_matcherActiveUI == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ActiveUI);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherActiveUI = matcher;
            }

            return _matcherActiveUI;
        }
    }
}
