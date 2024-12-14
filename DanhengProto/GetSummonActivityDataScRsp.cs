using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200081B RID: 2075
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSummonActivityDataScRsp : IMessage<GetSummonActivityDataScRsp>, IMessage, IEquatable<GetSummonActivityDataScRsp>, IDeepCloneable<GetSummonActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06005C64 RID: 23652 RVA: 0x000F57AD File Offset: 0x000F39AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSummonActivityDataScRsp> Parser
		{
			get
			{
				return GetSummonActivityDataScRsp._parser;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06005C65 RID: 23653 RVA: 0x000F57B4 File Offset: 0x000F39B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSummonActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06005C66 RID: 23654 RVA: 0x000F57C6 File Offset: 0x000F39C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSummonActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x000F57CD File Offset: 0x000F39CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSummonActivityDataScRsp()
		{
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x000F57E0 File Offset: 0x000F39E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSummonActivityDataScRsp(GetSummonActivityDataScRsp other) : this()
		{
			this.gEBAEDFNBME_ = other.gEBAEDFNBME_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x000F5816 File Offset: 0x000F3A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSummonActivityDataScRsp Clone()
		{
			return new GetSummonActivityDataScRsp(this);
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06005C6A RID: 23658 RVA: 0x000F581E File Offset: 0x000F3A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PJAHEBJMLGH> GEBAEDFNBME
		{
			get
			{
				return this.gEBAEDFNBME_;
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06005C6B RID: 23659 RVA: 0x000F5826 File Offset: 0x000F3A26
		// (set) Token: 0x06005C6C RID: 23660 RVA: 0x000F582E File Offset: 0x000F3A2E
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

		// Token: 0x06005C6D RID: 23661 RVA: 0x000F5837 File Offset: 0x000F3A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSummonActivityDataScRsp);
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x000F5848 File Offset: 0x000F3A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSummonActivityDataScRsp other)
		{
			return other != null && (other == this || (this.gEBAEDFNBME_.Equals(other.gEBAEDFNBME_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x000F5898 File Offset: 0x000F3A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gEBAEDFNBME_.GetHashCode();
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

		// Token: 0x06005C70 RID: 23664 RVA: 0x000F58E5 File Offset: 0x000F3AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x000F58ED File Offset: 0x000F3AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x000F58F8 File Offset: 0x000F3AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.gEBAEDFNBME_.WriteTo(ref output, GetSummonActivityDataScRsp._repeated_gEBAEDFNBME_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x000F5948 File Offset: 0x000F3B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gEBAEDFNBME_.CalculateSize(GetSummonActivityDataScRsp._repeated_gEBAEDFNBME_codec);
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

		// Token: 0x06005C74 RID: 23668 RVA: 0x000F599C File Offset: 0x000F3B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSummonActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.gEBAEDFNBME_.Add(other.gEBAEDFNBME_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x000F59E9 File Offset: 0x000F3BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x000F59F4 File Offset: 0x000F3BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gEBAEDFNBME_.AddEntriesFrom(ref input, GetSummonActivityDataScRsp._repeated_gEBAEDFNBME_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040023B9 RID: 9145
		private static readonly MessageParser<GetSummonActivityDataScRsp> _parser = new MessageParser<GetSummonActivityDataScRsp>(() => new GetSummonActivityDataScRsp());

		// Token: 0x040023BA RID: 9146
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023BB RID: 9147
		public const int GEBAEDFNBMEFieldNumber = 15;

		// Token: 0x040023BC RID: 9148
		private static readonly FieldCodec<PJAHEBJMLGH> _repeated_gEBAEDFNBME_codec = FieldCodec.ForMessage<PJAHEBJMLGH>(122U, PJAHEBJMLGH.Parser);

		// Token: 0x040023BD RID: 9149
		private readonly RepeatedField<PJAHEBJMLGH> gEBAEDFNBME_ = new RepeatedField<PJAHEBJMLGH>();

		// Token: 0x040023BE RID: 9150
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040023BF RID: 9151
		private uint retcode_;
	}
}
