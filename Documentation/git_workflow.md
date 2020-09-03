## Table of Contents
- [Overview](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#overview)
- [Useful CLI Commands](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#useful-cli-commands)
- [Basic Bash Commands (Mac/Linux OS Terminals)](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#basic-bash-commands-maclinux-os-terminals)
- [Github Workflow for Shared Projects: CLI and Web](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#github-workflow-for-shared-projects-cli-and-web)


### Overview
- [Github Workflow for Shared Projects: CLI and Web]()
- [Terms]()
- [Useful CLI Commands](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#useful-cli-commands)
- [Basic Bash Commands (Mac/Linux OS Terminals)](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#basic-bash-commands-maclinux-os-terminals)
- [Concepts and Best Practices](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#concepts-and-best-practices)
- [Common Issues](https://github.com/casierea/ThemePark/blob/master/Documentation/git_workflow.md#common-issues)


### Github Workflow for Shared Projects: CLI and Web
- Fork the repository (Web UI)
- Clone your fork (CLI with URL from Web UI)
- Set up remotes: (CLI)
	- Add upstream to main repository
	- `git add remote upstream <remote url>`
- Create a working branch (CLI)
	- `git checkout -b <branch name>`
- Do work that changes files 
- Add file changes to a commit (CLI)
	- `git add <filename>`
- Add a commit message (CLI)
	- `git commit -m "<message>"`
- Push changes to the branch of your fork (CLI)
	- `git push origin <remote>`
	- Repeat as needed
- Create a Pull Request between your fork's working branch and the master branch of the main repo (Web UI or CLI)
	- This could be to a different branch of the main repo
- Have team member(s) review the Pull Request and post comments for changes needed (Web UI)
- Address comments via discussion, posting tickets, committing new file changes and pushing to working branch of your fork (Web UI and local work)
	- Repeat as needed
- Reviewer merges the Pull Request (Web UI)
- Check out the `master` branch of your local copy of your fork (CLI)
	- `git checkout master`
- Pull changes from the `upstream` remote into your local master branch of your fork (CLI)
	- Upstream is a naming convention for the main repository that you forked
	- `git pull upstream master`
- Push changes from your local master branch to your `origin` master branch (CLI)
	- Origin is the default remote name for the repository you cloned
	- `git push origin master`


### Terms
- CLI: command line interface, usually accessed via a Terminal or Powershell type application
- Version control: Version control is a system that records changes to a file or set of files over time so that you can recall specific versions later.
- Repository: The place where code or application files are stored. This is often remotely hosted.
 Fork: A repository copy owned by a different user than the original repository. Useful for group projects or to create separate versions of source code with different features.
- Clone: Copying of a remote repository to the local file system for use or development.
- Remote: The URL used to access the remote file storage system during `push`, `pull`, `clone`, and other operations.
- Branch: A copy of repository code for which changes are tracked independently. Changes made to branches are integrated using Pull Requests.
- Working branch: Where code changes are made. It is best to not make changes directly onto master branches.
- Commit: 
	- noun: a set of changes to tracked files. Usually pushed to the remote repository for review.
	- verb: to add file changes to the staging area in preparation for pushing the changes to a remote or initiating a pull request to another branch.
- Head: the last commit being tracked by Git. This can be `reset` or `reverted` as needed.
- Pull Request: The process of reqesting to integrate changes made in one branch into another branch. Changes are "pulled" from one branch to the other. Changes are in the form of one or more commits.
- Diff: short for difference, shows the changes between file versions. The diff is used to compare line changes during a pull request.
- Tagging: Labeling a commit to have a specific name that allows it to be referenced for later use.


### Useful CLI Commands
- Clone a repository: `git clone <url>`
- Viewing remotes: `git remote -v`
- Rename remote: `git remote rename <old name> <new name>`
- Add remote: `git remote add <remote name> <remote URL>`
- Remove remote: `git remote remove <remote name>`
- Creating and checking out a branch: `git checkout -b <branch name>`
- Checking out branches: `git checkout <branch name>`
- Checking status of changed files: `git status`
- Adding files: `git add <filename>`
- Committing messages: `git commit -m "<message>"`
- Deleting a file: `git rm <filename>`


### Basic Bash Commands (Mac/Linux OS Terminals)
- Change directory: `cd <directory path and name>`
- Print current directory: `pwd`
- List files and directories: `ls`
- Count lines in file: `wc -l`
- Delete file: `rm <file name>`
- Create directory: `mkdir <directory>`
- Create file: `touch <file name>`
- Remove directory: `rmdir <directory>`


### Concepts and Best Practices
- Version tracking: software is often released in versions. Git tagging allows for certain versions to be labeled for release and reference. Tagging to stable releases allows others to examine the functioning code at different points in time and preserves a save point in the event of problems on the master branch of the repository.
- Merge conflicts: Occur when multiple sources attempt to change the same file under version control. This can occur when using both the GitHub web UI and local file system to make changes, or when multiple contributors make changes to the same file without integration between pull requests. Merge conflicts can be minimized by using a standardized workflow practice and by pulling updates to the master branch of the main repository into your working branch.
- Storing data files: many developers believe it is not appropriate to store data files in GitHub. Storing data increases time to clone repositories as the files need to be downloaded. 
- .gitignore: is a list of files and folder paths that are explicitly not checked when Git examines the local file system for changes. Ignored files and paths can still be added to version control using the `-F` flag in the `git add` command.
- tracked files: Git will track only files that are added using `git add`, other files may be present in the same directories, but will not be tracked unless added. This can be seen in the output of `git status`. Modifying files under version control using non-git controls will result in extra work to integrate those changes to the git versioning system. Common causes are renaming, moving, and deleting of files.
- Remote naming: remote URL references (refs) can be renamed. Commonly the main repository that has been forked will have a remote named upstream and the local clone of the fork will be named origin. Setting up remotes, either when cloning or creating remotes, in the format `https://username:password@github.com/username/repository.git` allows passing of credentials without calling them explicitly. Note, this stores your credentials in your bash history file and is thus less secure.
- Main repository: has master branch for the project and versions for releases. The master of this repository should always be in a functioning state.
- Pull requests: Should never be merged by the pull request creator. Having others review and test pull requests ensures that new code does not cause bugs or conflicts with the existing code base. Discussion of changes needed to a pull request are usually had in the GitHub web UI to record the decisions and reasoning.


### Common Issues
- File size: GitHub requires special software and repository settings to allow files over 100MB to be pushed and stored. A file of this size in a commit will stop the commit from being pushed and will need to be removed.
- Merge conflicts: can be addressed in a text editor, GitHub web UI, VI via the Terminal, or in a Git desktop application. Usually it is fairly simple to determine which changes should take precedence, copying the desired file contents and re committing can solve these problems. More complicated issues arise when changes from multiple source files need to be integrated. It is best to avoid these situations by pulling work in sequentially and updating subsequent PRs by pulling upstream changes into the working branches of the relevant forks.
- Adding too many files: using `git add .` will add the changes of all version controlled files to the commit. This is not always desired. A single message per commit is allowed and it can be difficult to describe the changes and reason for the changes for many files. More problematic is the inadvertant inclusion of files that should not be added to the commit or version control. Use caution when adding files.
