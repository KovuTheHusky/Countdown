using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

/// <summary>
/// Provides static methods for serializing any serializable object.
/// </summary>
public static class GenericSerializer
{
    /// <summary>
    /// Saves the specified object to the specified file in XML.
    /// </summary>
    /// <param name="filename">The filename to which the object should be saved.</param>
    /// <param name="o">The object to serialize.</param>
    /// <typeparam name="T">The type of the object to serialize.</typeparam>
    public static void SerializeXML<T>(string filename, object o)
        where T : class
    {
        try
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            TextWriter w = new StreamWriter(filename, false);
            s.Serialize(w, o);
            w.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while saving this object.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    /// <summary>
    /// Loads an object from the specified XML file.
    /// </summary>
    /// <param name="filename">The filename to load.</param>
    /// <typeparam name="T">The type of object to deserialize.</typeparam>
    /// <returns>The object contained within the specified file, or <code>null</code>
    /// if an error occurred while loading.</returns>
    public static T DeserializeXML<T>(string filename)
        where T : class
    {
        return DeserializeXML<T>(filename, true);
    }

    /// <summary>
    /// Loads an object from the specified XML file.
    /// </summary>
    /// <param name="filename">The filename to load.</param>
    /// <param name="catchErrors">Whether or not to handle errors during file loading by displaying a message box.</param>
    /// <typeparam name="t">The type of object to deserialize.</typeparam>
    /// <returns>The object contained within the specified file, or <code>null</code>
    /// if an error occurred while loading.</returns>
    public static T DeserializeXML<T>(string filename, bool catchErrors)
        where T : class
    {
        try
        {
            object o;
            XmlSerializer s = new XmlSerializer(typeof(T));
            TextReader r = new StreamReader(filename);
            o = s.Deserialize(r);
            r.Close();
            return (T)o;
        }
        catch (Exception ex)
        {
            if (catchErrors)
            {
                MessageBox.Show("An error occurred while loading this object.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
    }

    /// <summary>
    /// Saves the specified object to the specified file in XML.
    /// </summary>
    /// <param name="filename">The filename to which the object should be saved.</param>
    /// <param name="t">The type of object to serialize.</param>
    /// <param name="o">The object to serialize.</param>
    [Obsolete]
    public static void SerializeXML(string filename, object o, Type t)
    {
        try
        {
            XmlSerializer s = new XmlSerializer(t);
            TextWriter w = new StreamWriter(filename, false);
            s.Serialize(w, o);
            w.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while saving this object.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    /// <summary>
    /// Loads an object from the specified XML file.
    /// </summary>
    /// <param name="filename">The filename to load.</param>
    /// <param name="t">The type of object to deserialize.</param>
    /// <returns>The object contained within the specified file, or <code>null</code>
    /// if an error occurred while loading.</returns>
    [Obsolete]
    public static object DeserializeXML(string filename, Type t)
    {
        return DeserializeXML(filename, t, true);
    }

    /// <summary>
    /// Loads an object from the specified XML file.
    /// </summary>
    /// <param name="filename">The filename to load.</param>
    /// <param name="catchErrors">Whether or not to handle errors during file loading by displaying a message box.</param>
    /// <param name="t">The type of object to deserialize.</param>
    /// <returns>The object contained within the specified file, or <code>null</code>
    /// if an error occurred while loading.</returns>
    [Obsolete]
    public static object DeserializeXML(string filename, Type t, bool catchErrors)
    {
        try
        {
            object o;
            XmlSerializer s = new XmlSerializer(t);
            TextReader r = new StreamReader(filename);
            o = s.Deserialize(r);
            r.Close();
            return o;
        }
        catch (Exception ex)
        {
            if (catchErrors)
            {
                MessageBox.Show("An error occurred while loading this object.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
    }

    /// <summary>
    /// Saves the specified object to the specified file.
    /// </summary>
    /// <param name="filename">The filename to which the object should be saved.</param>
    /// <param name="o">The object to serialize.</param>
    public static void Serialize(string filename, object o)
    {
        try
        {
            FileStream flStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter binFormatter = new BinaryFormatter();
            binFormatter.Serialize(flStream, o);
            flStream.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while saving this object.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    /// <summary>
    /// Loads an object from the specified file.
    /// </summary>
    /// <param name="filename">The filename to load.</param>
    /// <returns>The object contained within the specified file, or <code>null</code>
    /// if an error occurred while loading.</returns>
    public static object Deserialize(string filename)
    {
        return Deserialize(filename, true);
    }

    /// <summary>
    /// Loads an object from the specified file.
    /// </summary>
    /// <param name="filename">The filename to load.</param>
    /// <param name="catchErrors">Whether or not to handle errors during file loading by displaying a message box.</param>
    /// <returns>The object contained within the specified file, or <code>null</code>
    /// if an error occurred while loading.</returns>
    public static object Deserialize(string filename, bool catchErrors)
    {
        try
        {
            object o;
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            BinaryFormatter binFormatter = new BinaryFormatter();
            o = binFormatter.Deserialize(fs);
            sr.Close();
            fs.Close();
            return o;
        }
        catch (Exception ex)
        {
            if (catchErrors)
            {
                MessageBox.Show("An error occurred while loading this object.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
    }
}