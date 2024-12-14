using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C1 RID: 4289
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerPrefs : IMessage<ServerPrefs>, IMessage, IEquatable<ServerPrefs>, IDeepCloneable<ServerPrefs>, IBufferMessage
	{
		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600BF45 RID: 48965 RVA: 0x00203248 File Offset: 0x00201448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerPrefs> Parser
		{
			get
			{
				return ServerPrefs._parser;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600BF46 RID: 48966 RVA: 0x0020324F File Offset: 0x0020144F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerPrefsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x00203261 File Offset: 0x00201461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerPrefs.Descriptor;
			}
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x00203268 File Offset: 0x00201468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerPrefs()
		{
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x0020327B File Offset: 0x0020147B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerPrefs(ServerPrefs other) : this()
		{
			this.serverPrefsId_ = other.serverPrefsId_;
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF4A RID: 48970 RVA: 0x002032AC File Offset: 0x002014AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerPrefs Clone()
		{
			return new ServerPrefs(this);
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600BF4B RID: 48971 RVA: 0x002032B4 File Offset: 0x002014B4
		// (set) Token: 0x0600BF4C RID: 48972 RVA: 0x002032BC File Offset: 0x002014BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ServerPrefsId
		{
			get
			{
				return this.serverPrefsId_;
			}
			set
			{
				this.serverPrefsId_ = value;
			}
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600BF4D RID: 48973 RVA: 0x002032C5 File Offset: 0x002014C5
		// (set) Token: 0x0600BF4E RID: 48974 RVA: 0x002032CD File Offset: 0x002014CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x0600BF4F RID: 48975 RVA: 0x002032E0 File Offset: 0x002014E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerPrefs);
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x002032F0 File Offset: 0x002014F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServerPrefs other)
		{
			return other != null && (other == this || (this.ServerPrefsId == other.ServerPrefsId && !(this.Data != other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x00203340 File Offset: 0x00201540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerPrefsId != 0U)
			{
				num ^= this.ServerPrefsId.GetHashCode();
			}
			if (this.Data.Length != 0)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF52 RID: 48978 RVA: 0x0020339A File Offset: 0x0020159A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BF53 RID: 48979 RVA: 0x002033A2 File Offset: 0x002015A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x002033AC File Offset: 0x002015AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Data.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.Data);
			}
			if (this.ServerPrefsId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ServerPrefsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x0020340C File Offset: 0x0020160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerPrefsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServerPrefsId);
			}
			if (this.Data.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF56 RID: 48982 RVA: 0x00203468 File Offset: 0x00201668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServerPrefs other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerPrefsId != 0U)
			{
				this.ServerPrefsId = other.ServerPrefsId;
			}
			if (other.Data.Length != 0)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF57 RID: 48983 RVA: 0x002034BD File Offset: 0x002016BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF58 RID: 48984 RVA: 0x002034C8 File Offset: 0x002016C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ServerPrefsId = input.ReadUInt32();
					}
				}
				else
				{
					this.Data = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004DAE RID: 19886
		private static readonly MessageParser<ServerPrefs> _parser = new MessageParser<ServerPrefs>(() => new ServerPrefs());

		// Token: 0x04004DAF RID: 19887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DB0 RID: 19888
		public const int ServerPrefsIdFieldNumber = 12;

		// Token: 0x04004DB1 RID: 19889
		private uint serverPrefsId_;

		// Token: 0x04004DB2 RID: 19890
		public const int DataFieldNumber = 9;

		// Token: 0x04004DB3 RID: 19891
		private ByteString data_ = ByteString.Empty;
	}
}
