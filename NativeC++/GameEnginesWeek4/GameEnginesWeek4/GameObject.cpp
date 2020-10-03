#include "GameObject.h"

GameObject::GameObject()
{
	SetID();
	SetPosition();
}

int GameObject::GetID() const
{
	return m_id;
}

void GameObject::SetID(int id)
{
	m_id = id;
}

Vector3D GameObject::GetPosition() const
{
	return m_position;
}

void GameObject::SetPosition(float x, float y, float z)
{
	m_position.x = x;
	m_position.y = y;
	m_position.z = z;

}
