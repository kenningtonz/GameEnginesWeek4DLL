#include "Wrapper.h"
#include "GameObject.h"

GameObject gameObject;

PLUGIN_API int GetID()
{
	return gameObject.GetID();
}

PLUGIN_API void SetID(int id)
{
	return gameObject.SetID();
}

PLUGIN_API Vector3D GetPosition()
{
	return gameObject.GetPosition();
}

PLUGIN_API void SetPosition(float x, float y, float z)
{
	return gameObject.SetPosition(x, y, z);
}
