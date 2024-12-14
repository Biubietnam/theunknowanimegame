using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C21 RID: 3105
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NMGJCHNEGGF : IMessage<NMGJCHNEGGF>, IMessage, IEquatable<NMGJCHNEGGF>, IDeepCloneable<NMGJCHNEGGF>, IBufferMessage
	{
		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600898F RID: 35215 RVA: 0x0016B510 File Offset: 0x00169710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NMGJCHNEGGF> Parser
		{
			get
			{
				return NMGJCHNEGGF._parser;
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x0016B517 File Offset: 0x00169717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NMGJCHNEGGFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x06008991 RID: 35217 RVA: 0x0016B529 File Offset: 0x00169729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NMGJCHNEGGF.Descriptor;
			}
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x0016B530 File Offset: 0x00169730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NMGJCHNEGGF()
		{
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x0016B543 File Offset: 0x00169743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NMGJCHNEGGF(NMGJCHNEGGF other) : this()
		{
			this.scriptId_ = other.scriptId_;
			this.pJFMIJCNFMC_ = other.pJFMIJCNFMC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x0016B579 File Offset: 0x00169779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NMGJCHNEGGF Clone()
		{
			return new NMGJCHNEGGF(this);
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x06008995 RID: 35221 RVA: 0x0016B581 File Offset: 0x00169781
		// (set) Token: 0x06008996 RID: 35222 RVA: 0x0016B589 File Offset: 0x00169789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x06008997 RID: 35223 RVA: 0x0016B592 File Offset: 0x00169792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PJFMIJCNFMC
		{
			get
			{
				return this.pJFMIJCNFMC_;
			}
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x0016B59A File Offset: 0x0016979A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NMGJCHNEGGF);
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x0016B5A8 File Offset: 0x001697A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NMGJCHNEGGF other)
		{
			return other != null && (other == this || (this.ScriptId == other.ScriptId && this.pJFMIJCNFMC_.Equals(other.pJFMIJCNFMC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x0016B5F8 File Offset: 0x001697F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			num ^= this.pJFMIJCNFMC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x0016B645 File Offset: 0x00169845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x0016B64D File Offset: 0x0016984D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x0016B658 File Offset: 0x00169858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ScriptId);
			}
			this.pJFMIJCNFMC_.WriteTo(ref output, NMGJCHNEGGF._repeated_pJFMIJCNFMC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x0016B6A8 File Offset: 0x001698A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			num += this.pJFMIJCNFMC_.CalculateSize(NMGJCHNEGGF._repeated_pJFMIJCNFMC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600899F RID: 35231 RVA: 0x0016B6FC File Offset: 0x001698FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NMGJCHNEGGF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			this.pJFMIJCNFMC_.Add(other.pJFMIJCNFMC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x0016B749 File Offset: 0x00169949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x0016B754 File Offset: 0x00169954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.pJFMIJCNFMC_.AddEntriesFrom(ref input, NMGJCHNEGGF._repeated_pJFMIJCNFMC_codec);
					}
				}
				else
				{
					this.ScriptId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040034C3 RID: 13507
		private static readonly MessageParser<NMGJCHNEGGF> _parser = new MessageParser<NMGJCHNEGGF>(() => new NMGJCHNEGGF());

		// Token: 0x040034C4 RID: 13508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034C5 RID: 13509
		public const int ScriptIdFieldNumber = 3;

		// Token: 0x040034C6 RID: 13510
		private uint scriptId_;

		// Token: 0x040034C7 RID: 13511
		public const int PJFMIJCNFMCFieldNumber = 12;

		// Token: 0x040034C8 RID: 13512
		private static readonly FieldCodec<uint> _repeated_pJFMIJCNFMC_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x040034C9 RID: 13513
		private readonly RepeatedField<uint> pJFMIJCNFMC_ = new RepeatedField<uint>();
	}
}
