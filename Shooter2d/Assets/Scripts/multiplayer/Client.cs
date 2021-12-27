/*

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;



public class Client : MonoBehaviour
{

    public static Client instance;
    public static int bufferSize = 4096;

    public string ip = "127.0.0.1";
    public int port = 8081;
    public int id = 0;
    public TCP tcp;




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    private void Start()
    {
        tcp == new TCP();
    }

    /*

    private void OnApplicationQuit()
    {
        Disconnect(); // Disconnect when the game is closed
    }


// Attempts to connect to the server.
public void ConnectToServer()
    {
        tcp = new TCP();
        udp = new UDP();

        InitializeClientData();

        isConnected = true;
        tcp.Connect(); // Connect tcp, udp gets connected once tcp is done
    }

    public class TCP
    {
        public TcpClient socket;

        private NetworkStream stream;
        private Packet receivedData;
        private byte[] receiveBuffer;

        // Attempts to connect to the server via TCP.
        public void Connect()
        {
            socket = new TcpClient
            {
                ReceiveBufferSize = dataBufferSize,
                SendBufferSize = dataBufferSize
            };

            receiveBuffer = new byte[dataBufferSize];
            socket.BeginConnect(instance.ip, instance.port, ConnectCallback, socket);
        }

        // Initializes the newly connected client's TCP-related info.
        private void ConnectCallback(IAsyncResult _result)
        {
            socket.EndConnect(_result);

            if (!socket.Connected)
            {
                return;
            }

            stream = socket.GetStream();

            receivedData = new Packet();

            stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);
        }

    */

/*
/// <summary>Sends data to the client via TCP.</summary>
/// <param name="_packet">The packet to send.</param>
public void SendData(Packet _packet)
{
    try
    {
        if (socket != null)
        {
            stream.BeginWrite(_packet.ToArray(), 0, _packet.Length(), null, null); // Send data to server
        }
    }
    catch (Exception _ex)
    {
        Debug.Log($"Error sending data to server via TCP: {_ex}");
    }
}
*/

/*

//Reads incoming data from the stream.
private void ReceiveCallback(IAsyncResult _result)
        {
            try
            {
                int _byteLength = stream.EndRead(_result);
                if (_byteLength <= 0)
                {
                    instance.Disconnect();
                    return;
                }

                byte[] _data = new byte[_byteLength];
                Array.Copy(receiveBuffer, _data, _byteLength);

                receivedData.Reset(HandleData(_data)); // Reset receivedData if all data was handled
                stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);
            }
            catch
            {
                Disconnect();
            }
        }

    }

*/