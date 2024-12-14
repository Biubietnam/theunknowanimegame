using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003B9 RID: 953
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DMDEOGJEGPI : IMessage<DMDEOGJEGPI>, IMessage, IEquatable<DMDEOGJEGPI>, IDeepCloneable<DMDEOGJEGPI>, IBufferMessage
	{
		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000762B0 File Offset: 0x000744B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DMDEOGJEGPI> Parser
		{
			get
			{
				return DMDEOGJEGPI._parser;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000762B7 File Offset: 0x000744B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DMDEOGJEGPIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000762C9 File Offset: 0x000744C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DMDEOGJEGPI.Descriptor;
			}
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x000762D0 File Offset: 0x000744D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DMDEOGJEGPI()
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000762D8 File Offset: 0x000744D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DMDEOGJEGPI(DMDEOGJEGPI other) : this()
		{
			this.hasTakenReward_ = other.hasTakenReward_;
			this.hOFPJFHLPGP_ = other.hOFPJFHLPGP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00076309 File Offset: 0x00074509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DMDEOGJEGPI Clone()
		{
			return new DMDEOGJEGPI(this);
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x00076311 File Offset: 0x00074511
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x00076319 File Offset: 0x00074519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTakenReward
		{
			get
			{
				return this.hasTakenReward_;
			}
			set
			{
				this.hasTakenReward_ = value;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x00076322 File Offset: 0x00074522
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x0007632A File Offset: 0x0007452A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HOFPJFHLPGP
		{
			get
			{
				return this.hOFPJFHLPGP_;
			}
			set
			{
				this.hOFPJFHLPGP_ = value;
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00076333 File Offset: 0x00074533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DMDEOGJEGPI);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00076341 File Offset: 0x00074541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DMDEOGJEGPI other)
		{
			return other != null && (other == this || (this.HasTakenReward == other.HasTakenReward && this.HOFPJFHLPGP == other.HOFPJFHLPGP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00076380 File Offset: 0x00074580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasTakenReward)
			{
				num ^= this.HasTakenReward.GetHashCode();
			}
			if (this.HOFPJFHLPGP != 0U)
			{
				num ^= this.HOFPJFHLPGP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x000763D8 File Offset: 0x000745D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000763E0 File Offset: 0x000745E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000763EC File Offset: 0x000745EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasTakenReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.HasTakenReward);
			}
			if (this.HOFPJFHLPGP != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.HOFPJFHLPGP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00076448 File Offset: 0x00074648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasTakenReward)
			{
				num += 2;
			}
			if (this.HOFPJFHLPGP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HOFPJFHLPGP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00076494 File Offset: 0x00074694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DMDEOGJEGPI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasTakenReward)
			{
				this.HasTakenReward = other.HasTakenReward;
			}
			if (other.HOFPJFHLPGP != 0U)
			{
				this.HOFPJFHLPGP = other.HOFPJFHLPGP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x000764E4 File Offset: 0x000746E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000764F0 File Offset: 0x000746F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HOFPJFHLPGP = input.ReadUInt32();
					}
				}
				else
				{
					this.HasTakenReward = input.ReadBool();
				}
			}
		}

		// Token: 0x0400112A RID: 4394
		private static readonly MessageParser<DMDEOGJEGPI> _parser = new MessageParser<DMDEOGJEGPI>(() => new DMDEOGJEGPI());

		// Token: 0x0400112B RID: 4395
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400112C RID: 4396
		public const int HasTakenRewardFieldNumber = 2;

		// Token: 0x0400112D RID: 4397
		private bool hasTakenReward_;

		// Token: 0x0400112E RID: 4398
		public const int HOFPJFHLPGPFieldNumber = 10;

		// Token: 0x0400112F RID: 4399
		private uint hOFPJFHLPGP_;
	}
}
