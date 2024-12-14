using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000945 RID: 2373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IPCMEMCHCPI : IMessage<IPCMEMCHCPI>, IMessage, IEquatable<IPCMEMCHCPI>, IDeepCloneable<IPCMEMCHCPI>, IBufferMessage
	{
		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x0011A9FD File Offset: 0x00118BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IPCMEMCHCPI> Parser
		{
			get
			{
				return IPCMEMCHCPI._parser;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060069EA RID: 27114 RVA: 0x0011AA04 File Offset: 0x00118C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IPCMEMCHCPIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x0011AA16 File Offset: 0x00118C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IPCMEMCHCPI.Descriptor;
			}
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x0011AA1D File Offset: 0x00118C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IPCMEMCHCPI()
		{
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x0011AA25 File Offset: 0x00118C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IPCMEMCHCPI(IPCMEMCHCPI other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x0011AA56 File Offset: 0x00118C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IPCMEMCHCPI Clone()
		{
			return new IPCMEMCHCPI(this);
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x0011AA5E File Offset: 0x00118C5E
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x0011AA66 File Offset: 0x00118C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060069F1 RID: 27121 RVA: 0x0011AA6F File Offset: 0x00118C6F
		// (set) Token: 0x060069F2 RID: 27122 RVA: 0x0011AA77 File Offset: 0x00118C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x0011AA80 File Offset: 0x00118C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IPCMEMCHCPI);
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x0011AA8E File Offset: 0x00118C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IPCMEMCHCPI other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x0011AACC File Offset: 0x00118CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x0011AB2A File Offset: 0x00118D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x0011AB32 File Offset: 0x00118D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x0011AB3C File Offset: 0x00118D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0011AB98 File Offset: 0x00118D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0011ABF0 File Offset: 0x00118DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IPCMEMCHCPI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x0011AC40 File Offset: 0x00118E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x0011AC4C File Offset: 0x00118E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002891 RID: 10385
		private static readonly MessageParser<IPCMEMCHCPI> _parser = new MessageParser<IPCMEMCHCPI>(() => new IPCMEMCHCPI());

		// Token: 0x04002892 RID: 10386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002893 RID: 10387
		public const int AvatarIdFieldNumber = 6;

		// Token: 0x04002894 RID: 10388
		private uint avatarId_;

		// Token: 0x04002895 RID: 10389
		public const int AvatarTypeFieldNumber = 14;

		// Token: 0x04002896 RID: 10390
		private AvatarType avatarType_;
	}
}
