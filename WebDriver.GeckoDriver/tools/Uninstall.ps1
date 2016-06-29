param($installPath, $toolsPath, $package, $project)

$file = Join-Path $toolsPath '..\content\wires.exe' | Get-ChildItem

$project.ProjectItems.Item($file.Name).Delete()