# BowieCode
Personal Code/Snippet Library for Unity 3D

## Features

### BowieMath

- `CompareVectors` compares if Vector are close to equal.
- `MapIntervalF` maps an input float from one range to another.
- `SinF`is a sine wave generator with an amplitude, and frequency defined by `cyclesPerSecond`

### Components

- `BindToCamera` will position an transform a parent camera's near or far.
- `CameraFulstrumGizmo` alway shows the camera's fulstrum in the scene view even if the camera is not selected.
- `MotionCloner` applies a master transforms position, rotation and scale to components transform. Provides options for using local or world space, and retaining offsets.
- `MouseHider` hides the mouse after a set number of seconds.
- `Motion` applies trig based motions to selectable varibles of the transform component.
- `TextGizo` always displays text in the scene view.
- `RandomScale` applies a random scale to all or individual axises.
- `RandomOffset` applies a random position offset to to all or individual axises.

### Attributes

- `TagAttribute` and `TagDrawer` provides range tag selection for `string`.
- `MinMaxSliderAttribute` and `MinMaxSliderDrawer` provides range sliders for `Vector2`.

#### Utils

- `SceneRecorder` frame capture and video creation on OSX using ffmpeg installed by Homebrew.
- `ReorderableListUtil` wrapper to `Create` and `Draw` a reorderable list with the correct spacing. See example for usage.
- `BitmaskHelper` provides `IsSet`, `Set`, `Unset` enum helper.
- `Cycle` wraps a `Enumerable` into a container with a `Next` method.
- `Singleton` inherit from to make a singleton. Umm... not sure about this.
