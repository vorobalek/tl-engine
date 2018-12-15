#define _CRT_SECURE_NO_WARNINGS
#include<iostream>
using namespace std;
int main(int argc, char* argv[])
{
	char fname[] = ".last_migration_version";
	char* p_fname;
	if (argc > 1)
	{
		p_fname = argv[1];
	}
	else
	{
		p_fname = fname;
	}
	freopen(p_fname, "r", stdin);
	int v;
	cin >> v;
	freopen(p_fname, "w", stdout);
	cout << v + 1;
	return 0;
}