//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public JumpComponent jump { get { return (JumpComponent)GetComponent(InputComponentsLookup.Jump); } }
    public bool hasJump { get { return HasComponent(InputComponentsLookup.Jump); } }

    public void AddJump(GameEntity newEntity) {
        var index = InputComponentsLookup.Jump;
        var component = CreateComponent<JumpComponent>(index);
        component.entity = newEntity;
        AddComponent(index, component);
    }

    public void ReplaceJump(GameEntity newEntity) {
        var index = InputComponentsLookup.Jump;
        var component = CreateComponent<JumpComponent>(index);
        component.entity = newEntity;
        ReplaceComponent(index, component);
    }

    public void RemoveJump() {
        RemoveComponent(InputComponentsLookup.Jump);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherJump;

    public static Entitas.IMatcher<InputEntity> Jump {
        get {
            if (_matcherJump == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.Jump);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherJump = matcher;
            }

            return _matcherJump;
        }
    }
}