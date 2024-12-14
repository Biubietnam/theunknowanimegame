using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ACB RID: 2763
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MFDEGCNEJMO : IMessage<MFDEGCNEJMO>, IMessage, IEquatable<MFDEGCNEJMO>, IDeepCloneable<MFDEGCNEJMO>, IBufferMessage
	{
		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06007A67 RID: 31335 RVA: 0x00144435 File Offset: 0x00142635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MFDEGCNEJMO> Parser
		{
			get
			{
				return MFDEGCNEJMO._parser;
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06007A68 RID: 31336 RVA: 0x0014443C File Offset: 0x0014263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MFDEGCNEJMOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x06007A69 RID: 31337 RVA: 0x0014444E File Offset: 0x0014264E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MFDEGCNEJMO.Descriptor;
			}
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x00144455 File Offset: 0x00142655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFDEGCNEJMO()
		{
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x0014445D File Offset: 0x0014265D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFDEGCNEJMO(MFDEGCNEJMO other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x0014448E File Offset: 0x0014268E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFDEGCNEJMO Clone()
		{
			return new MFDEGCNEJMO(this);
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x00144496 File Offset: 0x00142696
		// (set) Token: 0x06007A6E RID: 31342 RVA: 0x0014449E File Offset: 0x0014269E
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

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x06007A6F RID: 31343 RVA: 0x001444A7 File Offset: 0x001426A7
		// (set) Token: 0x06007A70 RID: 31344 RVA: 0x001444AF File Offset: 0x001426AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x001444B8 File Offset: 0x001426B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MFDEGCNEJMO);
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x001444C6 File Offset: 0x001426C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MFDEGCNEJMO other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x00144504 File Offset: 0x00142704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x00144562 File Offset: 0x00142762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x0014456A File Offset: 0x0014276A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x00144574 File Offset: 0x00142774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x001445CC File Offset: 0x001427CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A78 RID: 31352 RVA: 0x00144624 File Offset: 0x00142824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MFDEGCNEJMO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A79 RID: 31353 RVA: 0x00144674 File Offset: 0x00142874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x00144680 File Offset: 0x00142880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarType = (AvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002F02 RID: 12034
		private static readonly MessageParser<MFDEGCNEJMO> _parser = new MessageParser<MFDEGCNEJMO>(() => new MFDEGCNEJMO());

		// Token: 0x04002F03 RID: 12035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F04 RID: 12036
		public const int AvatarTypeFieldNumber = 1;

		// Token: 0x04002F05 RID: 12037
		private AvatarType avatarType_;

		// Token: 0x04002F06 RID: 12038
		public const int IdFieldNumber = 2;

		// Token: 0x04002F07 RID: 12039
		private uint id_;
	}
}
