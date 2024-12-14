using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000075 RID: 117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AGLIOPELLCP : IMessage<AGLIOPELLCP>, IMessage, IEquatable<AGLIOPELLCP>, IDeepCloneable<AGLIOPELLCP>, IBufferMessage
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AGLIOPELLCP> Parser
		{
			get
			{
				return AGLIOPELLCP._parser;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000E4C3 File Offset: 0x0000C6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AGLIOPELLCPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000E4D5 File Offset: 0x0000C6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AGLIOPELLCP.Descriptor;
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000E4DC File Offset: 0x0000C6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AGLIOPELLCP()
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AGLIOPELLCP(AGLIOPELLCP other) : this()
		{
			this.stageType_ = other.stageType_;
			this.gJENBDIAKEG_ = other.gJENBDIAKEG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000E515 File Offset: 0x0000C715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AGLIOPELLCP Clone()
		{
			return new AGLIOPELLCP(this);
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0000E51D File Offset: 0x0000C71D
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x0000E525 File Offset: 0x0000C725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageType
		{
			get
			{
				return this.stageType_;
			}
			set
			{
				this.stageType_ = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0000E52E File Offset: 0x0000C72E
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0000E536 File Offset: 0x0000C736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GJENBDIAKEG
		{
			get
			{
				return this.gJENBDIAKEG_;
			}
			set
			{
				this.gJENBDIAKEG_ = value;
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000E53F File Offset: 0x0000C73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AGLIOPELLCP);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000E54D File Offset: 0x0000C74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AGLIOPELLCP other)
		{
			return other != null && (other == this || (this.StageType == other.StageType && this.GJENBDIAKEG == other.GJENBDIAKEG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000E58C File Offset: 0x0000C78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageType != 0U)
			{
				num ^= this.StageType.GetHashCode();
			}
			if (this.GJENBDIAKEG != 0U)
			{
				num ^= this.GJENBDIAKEG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageType != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.StageType);
			}
			if (this.GJENBDIAKEG != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GJENBDIAKEG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000E654 File Offset: 0x0000C854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageType);
			}
			if (this.GJENBDIAKEG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GJENBDIAKEG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000E6AC File Offset: 0x0000C8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AGLIOPELLCP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageType != 0U)
			{
				this.StageType = other.StageType;
			}
			if (other.GJENBDIAKEG != 0U)
			{
				this.GJENBDIAKEG = other.GJENBDIAKEG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000E708 File Offset: 0x0000C908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GJENBDIAKEG = input.ReadUInt32();
					}
				}
				else
				{
					this.StageType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040001CC RID: 460
		private static readonly MessageParser<AGLIOPELLCP> _parser = new MessageParser<AGLIOPELLCP>(() => new AGLIOPELLCP());

		// Token: 0x040001CD RID: 461
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001CE RID: 462
		public const int StageTypeFieldNumber = 3;

		// Token: 0x040001CF RID: 463
		private uint stageType_;

		// Token: 0x040001D0 RID: 464
		public const int GJENBDIAKEGFieldNumber = 13;

		// Token: 0x040001D1 RID: 465
		private uint gJENBDIAKEG_;
	}
}
