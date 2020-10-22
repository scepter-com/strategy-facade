namespace Source.Strategy.Scene
{
    interface ILoader
    {
        bool LoadSceneByID();

        bool LoadSceneByName();
    }
}