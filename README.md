# PoseCopier for Unity

## Overview

The `PoseCopier` is a Unity script that allows you to **copy and paste the position and rotation data** of a GameObject and all of its children. The data is stored in the system clipboard in JSON format, making it possible to copy poses from one instance of Unity and paste them into another.

This tool is useful for game developers who need to duplicate complex GameObject hierarchies with precise spatial configurations.

## Features

- **CopyPose**: This method gathers the position and rotation of the GameObject and its children, then converts this data into a JSON string and stores it in the system clipboard.

- **PastePose**: This method retrieves the pose data from the system clipboard, validates it, and then applies the stored positions and rotations to the GameObject and its children.

## Usage

Attach the `PoseCopier` script to the GameObject you want to copy. In the Unity Editor, use the custom inspector buttons to `Copy Pose` and `Paste Pose`.

## Note

This script uses the system clipboard to store data, which means the copied data may be lost if another application uses the clipboard or the computer is restarted.
