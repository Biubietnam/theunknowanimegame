using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001159 RID: 4441
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooBornCsReq : IMessage<SpaceZooBornCsReq>, IMessage, IEquatable<SpaceZooBornCsReq>, IDeepCloneable<SpaceZooBornCsReq>, IBufferMessage
	{
		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600C61F RID: 50719 RVA: 0x00213CC0 File Offset: 0x00211EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooBornCsReq> Parser
		{
			get
			{
				return SpaceZooBornCsReq._parser;
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600C620 RID: 50720 RVA: 0x00213CC7 File Offset: 0x00211EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooBornCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600C621 RID: 50721 RVA: 0x00213CD9 File Offset: 0x00211ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooBornCsReq.Descriptor;
			}
		}

		// Token: 0x0600C622 RID: 50722 RVA: 0x00213CE0 File Offset: 0x00211EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooBornCsReq()
		{
		}

		// Token: 0x0600C623 RID: 50723 RVA: 0x00213CF3 File Offset: 0x00211EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooBornCsReq(SpaceZooBornCsReq other) : this()
		{
			this.gKGBEFIHJKN_ = other.gKGBEFIHJKN_.Clone();
			this.oFGGGALLGPJ_ = other.oFGGGALLGPJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C624 RID: 50724 RVA: 0x00213D29 File Offset: 0x00211F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooBornCsReq Clone()
		{
			return new SpaceZooBornCsReq(this);
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600C625 RID: 50725 RVA: 0x00213D31 File Offset: 0x00211F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GKGBEFIHJKN
		{
			get
			{
				return this.gKGBEFIHJKN_;
			}
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600C626 RID: 50726 RVA: 0x00213D39 File Offset: 0x00211F39
		// (set) Token: 0x0600C627 RID: 50727 RVA: 0x00213D41 File Offset: 0x00211F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OFGGGALLGPJ
		{
			get
			{
				return this.oFGGGALLGPJ_;
			}
			set
			{
				this.oFGGGALLGPJ_ = value;
			}
		}

		// Token: 0x0600C628 RID: 50728 RVA: 0x00213D4A File Offset: 0x00211F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooBornCsReq);
		}

		// Token: 0x0600C629 RID: 50729 RVA: 0x00213D58 File Offset: 0x00211F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooBornCsReq other)
		{
			return other != null && (other == this || (this.gKGBEFIHJKN_.Equals(other.gKGBEFIHJKN_) && this.OFGGGALLGPJ == other.OFGGGALLGPJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C62A RID: 50730 RVA: 0x00213DA8 File Offset: 0x00211FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gKGBEFIHJKN_.GetHashCode();
			if (this.OFGGGALLGPJ != 0U)
			{
				num ^= this.OFGGGALLGPJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x00213DF5 File Offset: 0x00211FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C62C RID: 50732 RVA: 0x00213DFD File Offset: 0x00211FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x00213E08 File Offset: 0x00212008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OFGGGALLGPJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OFGGGALLGPJ);
			}
			this.gKGBEFIHJKN_.WriteTo(ref output, SpaceZooBornCsReq._repeated_gKGBEFIHJKN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C62E RID: 50734 RVA: 0x00213E58 File Offset: 0x00212058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gKGBEFIHJKN_.CalculateSize(SpaceZooBornCsReq._repeated_gKGBEFIHJKN_codec);
			if (this.OFGGGALLGPJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OFGGGALLGPJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C62F RID: 50735 RVA: 0x00213EAC File Offset: 0x002120AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooBornCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.gKGBEFIHJKN_.Add(other.gKGBEFIHJKN_);
			if (other.OFGGGALLGPJ != 0U)
			{
				this.OFGGGALLGPJ = other.OFGGGALLGPJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C630 RID: 50736 RVA: 0x00213EF9 File Offset: 0x002120F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x00213F04 File Offset: 0x00212104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gKGBEFIHJKN_.AddEntriesFrom(ref input, SpaceZooBornCsReq._repeated_gKGBEFIHJKN_codec);
					}
				}
				else
				{
					this.OFGGGALLGPJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005009 RID: 20489
		private static readonly MessageParser<SpaceZooBornCsReq> _parser = new MessageParser<SpaceZooBornCsReq>(() => new SpaceZooBornCsReq());

		// Token: 0x0400500A RID: 20490
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400500B RID: 20491
		public const int GKGBEFIHJKNFieldNumber = 8;

		// Token: 0x0400500C RID: 20492
		private static readonly FieldCodec<uint> _repeated_gKGBEFIHJKN_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x0400500D RID: 20493
		private readonly RepeatedField<uint> gKGBEFIHJKN_ = new RepeatedField<uint>();

		// Token: 0x0400500E RID: 20494
		public const int OFGGGALLGPJFieldNumber = 1;

		// Token: 0x0400500F RID: 20495
		private uint oFGGGALLGPJ_;
	}
}
