﻿
namespace PropertyFinder.Presenter
{
  /// <summary>
  /// A service which provides state persistence.
  /// </summary>
  public interface IStatePersistenceService
  {
    void SaveState(PropertyFinderPersistentState state);

    PropertyFinderPersistentState LoadState();
  }
}
