using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B57 RID: 2903
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGuessChooseScRsp : IMessage<MonopolyGuessChooseScRsp>, IMessage, IEquatable<MonopolyGuessChooseScRsp>, IDeepCloneable<MonopolyGuessChooseScRsp>, IBufferMessage
	{
		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x06008079 RID: 32889 RVA: 0x00152E81 File Offset: 0x00151081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGuessChooseScRsp> Parser
		{
			get
			{
				return MonopolyGuessChooseScRsp._parser;
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600807A RID: 32890 RVA: 0x00152E88 File Offset: 0x00151088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGuessChooseScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x00152E9A File Offset: 0x0015109A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGuessChooseScRsp.Descriptor;
			}
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x00152EA1 File Offset: 0x001510A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessChooseScRsp()
		{
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x00152EA9 File Offset: 0x001510A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessChooseScRsp(MonopolyGuessChooseScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.mGOCICCJGFE_ = other.mGOCICCJGFE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x00152EDA File Offset: 0x001510DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessChooseScRsp Clone()
		{
			return new MonopolyGuessChooseScRsp(this);
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x00152EE2 File Offset: 0x001510E2
		// (set) Token: 0x06008080 RID: 32896 RVA: 0x00152EEA File Offset: 0x001510EA
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

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x00152EF3 File Offset: 0x001510F3
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x00152EFB File Offset: 0x001510FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGOCICCJGFE
		{
			get
			{
				return this.mGOCICCJGFE_;
			}
			set
			{
				this.mGOCICCJGFE_ = value;
			}
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x00152F04 File Offset: 0x00151104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGuessChooseScRsp);
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x00152F12 File Offset: 0x00151112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGuessChooseScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.MGOCICCJGFE == other.MGOCICCJGFE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x00152F50 File Offset: 0x00151150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.MGOCICCJGFE != 0U)
			{
				num ^= this.MGOCICCJGFE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x00152FA8 File Offset: 0x001511A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x00152FB0 File Offset: 0x001511B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x00152FBC File Offset: 0x001511BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGOCICCJGFE != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MGOCICCJGFE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008089 RID: 32905 RVA: 0x00153018 File Offset: 0x00151218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.MGOCICCJGFE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGOCICCJGFE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x00153070 File Offset: 0x00151270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGuessChooseScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.MGOCICCJGFE != 0U)
			{
				this.MGOCICCJGFE = other.MGOCICCJGFE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x001530C0 File Offset: 0x001512C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x001530CC File Offset: 0x001512CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
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
					this.MGOCICCJGFE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400311A RID: 12570
		private static readonly MessageParser<MonopolyGuessChooseScRsp> _parser = new MessageParser<MonopolyGuessChooseScRsp>(() => new MonopolyGuessChooseScRsp());

		// Token: 0x0400311B RID: 12571
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400311C RID: 12572
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400311D RID: 12573
		private uint retcode_;

		// Token: 0x0400311E RID: 12574
		public const int MGOCICCJGFEFieldNumber = 5;

		// Token: 0x0400311F RID: 12575
		private uint mGOCICCJGFE_;
	}
}
