# Overview

## DesignerTech Videos - Introducing a Friend to Unity Game Engine

This is the GitHub repo mentioned in the first video of the series
as a place with the final example code file and the project settings.

[UntiyHub Introduction](https://youtu.be/18VjwNEvtzw)

## Exercises with this Code

The `Autobounce` class should have been renamed after it changed
purpose from being a fixed bounce motion to an Input driven
character controller.

When renaming classes, make sure the class name and the file name
match so class `Foo` is in `Foo.cs` because Unity needs those 
to be in-sync to find components.

### 1. Rename Autobounce to PlaneSkater

The version of `Autobounce` in this repo is moved using physics
to add rotational force and thrust to make it move, so it moves like
an ice skater on the ice.

Unity has some C# attributes that are very useful, we looked
at `Header` and `ToolTip` in the videos for giving hints in the Inspector window.

There is another attribute `RequiredComponent` that will tell
Unity that the GameObject needs a component to be added, as a dependency
of your custom component and Unity will add it, automatically, if missing.

Assuming you renamed the class and file to `PlaneSkater` then it
could start like this with the new attribute.

```c#
[RequireComponent(typeof(RigidBody))]
public class PlaneSkater : MonoBehaviour
{
    const float BASE = 0.5f;

    private Transform _Transform;
    private Rigidbody _Rigidbody;
    //.... end of snippet
```

And later, in the `Start()` method when we perform `GetComponent<RigidBody>()` we
know this will succeed because the RequireComponent attribute will enforce it being
present.

Another very handy attribute is `AddComponentMenu` that makes it easier to
use [Add Component] button in Unity's Inspector tab and find your custom components
by making your own menu hierarchy. If you wanted a component menu called *Overview*
then you would add an attribute as follows....

```c#
[AddComponentMenu("Overview/PlaneSkater")]
[RequireComponent(typeof(RigidBody))]
public class PlaneSkater : MonoBehaviour
{
```

Now, when you add a component to your GameObject, you will see a menu called *Overview* and
when you click on that, there will be a **PlaneSkater** component within it and that will be much easier to find.

### 2. Create a new AutoBounce by following Video 7

In video 7 we discuss ways to force a GameObject to move up and down
using `Mathf.Sin()` function.

### 3. Create a new component MoveController by following Video 8

In video 8, we took AutoBounce and give it logic to take Input values
and change the position and rotation using the `Transform` component.

Make a new C# class (using Unity context menu or in Visual Studio)
called `MoveController` and give it the logic shown in Video 8.
