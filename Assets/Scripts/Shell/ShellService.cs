using UnityEngine;

public class ShellService : MonoSingletonGeneric<ShellService>
{
     private ShellPoolService shellPoolService;

    private void Start()
    {
        shellPoolService = GetComponent<ShellPoolService>();
    }

    public ShellView SpawnShell(Transform spawnTransform)
    {
        ShellView shell = shellPoolService.GetShell();
        shell.gameObject.SetActive(true);
        shell.transform.position = spawnTransform.position;
        shell.transform.rotation = spawnTransform.rotation;
        return shell;
    }

    public void ReturnShellToPool(ShellView shell)
    {
        shell.gameObject.SetActive(false);
        shellPoolService.ReturnItem(shell);
    }
}