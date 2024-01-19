using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    [SerializeField] private PlayerView playerView;

    public override void InstallBindings()
    {
        Container.BindInterfacesTo<UserInputService>().AsSingle().NonLazy();
        Container.BindInterfacesTo<PlayerMoveService>().AsSingle().WithArguments(playerView).NonLazy();
    }
}
