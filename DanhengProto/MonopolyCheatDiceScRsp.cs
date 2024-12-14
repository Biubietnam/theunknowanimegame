using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B13 RID: 2835
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyCheatDiceScRsp : IMessage<MonopolyCheatDiceScRsp>, IMessage, IEquatable<MonopolyCheatDiceScRsp>, IDeepCloneable<MonopolyCheatDiceScRsp>, IBufferMessage
	{
		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x06007D7E RID: 32126 RVA: 0x0014C2B4 File Offset: 0x0014A4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyCheatDiceScRsp> Parser
		{
			get
			{
				return MonopolyCheatDiceScRsp._parser;
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x06007D7F RID: 32127 RVA: 0x0014C2BB File Offset: 0x0014A4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyCheatDiceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x06007D80 RID: 32128 RVA: 0x0014C2CD File Offset: 0x0014A4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyCheatDiceScRsp.Descriptor;
			}
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x0014C2D4 File Offset: 0x0014A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCheatDiceScRsp()
		{
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x0014C2DC File Offset: 0x0014A4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCheatDiceScRsp(MonopolyCheatDiceScRsp other) : this()
		{
			this.mGPAHNMBAMI_ = other.mGPAHNMBAMI_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x0014C30D File Offset: 0x0014A50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCheatDiceScRsp Clone()
		{
			return new MonopolyCheatDiceScRsp(this);
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x06007D84 RID: 32132 RVA: 0x0014C315 File Offset: 0x0014A515
		// (set) Token: 0x06007D85 RID: 32133 RVA: 0x0014C31D File Offset: 0x0014A51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGPAHNMBAMI
		{
			get
			{
				return this.mGPAHNMBAMI_;
			}
			set
			{
				this.mGPAHNMBAMI_ = value;
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x06007D86 RID: 32134 RVA: 0x0014C326 File Offset: 0x0014A526
		// (set) Token: 0x06007D87 RID: 32135 RVA: 0x0014C32E File Offset: 0x0014A52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06007D88 RID: 32136 RVA: 0x0014C337 File Offset: 0x0014A537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyCheatDiceScRsp);
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x0014C345 File Offset: 0x0014A545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyCheatDiceScRsp other)
		{
			return other != null && (other == this || (this.MGPAHNMBAMI == other.MGPAHNMBAMI && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x0014C384 File Offset: 0x0014A584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MGPAHNMBAMI != 0U)
			{
				num ^= this.MGPAHNMBAMI.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D8B RID: 32139 RVA: 0x0014C3DC File Offset: 0x0014A5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x0014C3E4 File Offset: 0x0014A5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x0014C3F0 File Offset: 0x0014A5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGPAHNMBAMI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MGPAHNMBAMI);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x0014C44C File Offset: 0x0014A64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MGPAHNMBAMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGPAHNMBAMI);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x0014C4A4 File Offset: 0x0014A6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyCheatDiceScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MGPAHNMBAMI != 0U)
			{
				this.MGPAHNMBAMI = other.MGPAHNMBAMI;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x0014C4F4 File Offset: 0x0014A6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x0014C500 File Offset: 0x0014A700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.MGPAHNMBAMI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003035 RID: 12341
		private static readonly MessageParser<MonopolyCheatDiceScRsp> _parser = new MessageParser<MonopolyCheatDiceScRsp>(() => new MonopolyCheatDiceScRsp());

		// Token: 0x04003036 RID: 12342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003037 RID: 12343
		public const int MGPAHNMBAMIFieldNumber = 5;

		// Token: 0x04003038 RID: 12344
		private uint mGPAHNMBAMI_;

		// Token: 0x04003039 RID: 12345
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400303A RID: 12346
		private uint retcode_;
	}
}
