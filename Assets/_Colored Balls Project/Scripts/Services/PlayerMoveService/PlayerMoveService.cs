using System;
using Zenject;

public class PlayerMoveService : IPlayerMoveService, ITickable
{
    private IPlayerMoveView _playerMoveView;
    private IUserInputMoveDataProvider _userInputMoveDataProvider;
    private bool _isEnabled;
    public PlayerMoveService(
        IPlayerMoveView playerMoveView,
        IUserInputMoveDataProvider userInputMoveDataProvider)
    {
        _playerMoveView = playerMoveView;
        _userInputMoveDataProvider = userInputMoveDataProvider;
        _isEnabled = true;
    }

    public void Enable()
    {
        _isEnabled = true;
    }

    public void Disable()
    {
        _isEnabled = false;
    }

    public void SetSpeed(float speed)
    {
        if (speed <= 0)
            throw new ArgumentException("The speed value cannot be less than or equal to zero");

        _playerMoveView.Speed = speed;
    }

    public void Tick()
    {
        if(!_isEnabled)
            return;

        if(!_userInputMoveDataProvider.IsMoved)
            return;

        _playerMoveView.Move(_userInputMoveDataProvider.MoveDirection);
    }
}