using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007BB RID: 1979
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueExhibitionScRsp : IMessage<GetRogueExhibitionScRsp>, IMessage, IEquatable<GetRogueExhibitionScRsp>, IDeepCloneable<GetRogueExhibitionScRsp>, IBufferMessage
	{
		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600584C RID: 22604 RVA: 0x000EC133 File Offset: 0x000EA333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueExhibitionScRsp> Parser
		{
			get
			{
				return GetRogueExhibitionScRsp._parser;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600584D RID: 22605 RVA: 0x000EC13A File Offset: 0x000EA33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueExhibitionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x000EC14C File Offset: 0x000EA34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueExhibitionScRsp.Descriptor;
			}
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x000EC153 File Offset: 0x000EA353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueExhibitionScRsp()
		{
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x000EC174 File Offset: 0x000EA374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueExhibitionScRsp(GetRogueExhibitionScRsp other) : this()
		{
			this.eINBMKMCFIA_ = other.eINBMKMCFIA_.Clone();
			this.aNEOFHIKDGK_ = other.aNEOFHIKDGK_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x000EC1C6 File Offset: 0x000EA3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueExhibitionScRsp Clone()
		{
			return new GetRogueExhibitionScRsp(this);
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06005852 RID: 22610 RVA: 0x000EC1CE File Offset: 0x000EA3CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BHOFJLLBKNB> EINBMKMCFIA
		{
			get
			{
				return this.eINBMKMCFIA_;
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06005853 RID: 22611 RVA: 0x000EC1D6 File Offset: 0x000EA3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IBFALCFDLDG> ANEOFHIKDGK
		{
			get
			{
				return this.aNEOFHIKDGK_;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06005854 RID: 22612 RVA: 0x000EC1DE File Offset: 0x000EA3DE
		// (set) Token: 0x06005855 RID: 22613 RVA: 0x000EC1E6 File Offset: 0x000EA3E6
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

		// Token: 0x06005856 RID: 22614 RVA: 0x000EC1EF File Offset: 0x000EA3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueExhibitionScRsp);
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x000EC200 File Offset: 0x000EA400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueExhibitionScRsp other)
		{
			return other != null && (other == this || (this.eINBMKMCFIA_.Equals(other.eINBMKMCFIA_) && this.aNEOFHIKDGK_.Equals(other.aNEOFHIKDGK_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x000EC264 File Offset: 0x000EA464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.eINBMKMCFIA_.GetHashCode();
			num ^= this.aNEOFHIKDGK_.GetHashCode();
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

		// Token: 0x06005859 RID: 22617 RVA: 0x000EC2BF File Offset: 0x000EA4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x000EC2C7 File Offset: 0x000EA4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x000EC2D0 File Offset: 0x000EA4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			this.aNEOFHIKDGK_.WriteTo(ref output, GetRogueExhibitionScRsp._repeated_aNEOFHIKDGK_codec);
			this.eINBMKMCFIA_.WriteTo(ref output, GetRogueExhibitionScRsp._repeated_eINBMKMCFIA_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x000EC330 File Offset: 0x000EA530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eINBMKMCFIA_.CalculateSize(GetRogueExhibitionScRsp._repeated_eINBMKMCFIA_codec);
			num += this.aNEOFHIKDGK_.CalculateSize(GetRogueExhibitionScRsp._repeated_aNEOFHIKDGK_codec);
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

		// Token: 0x0600585D RID: 22621 RVA: 0x000EC394 File Offset: 0x000EA594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueExhibitionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.eINBMKMCFIA_.Add(other.eINBMKMCFIA_);
			this.aNEOFHIKDGK_.Add(other.aNEOFHIKDGK_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x000EC3F2 File Offset: 0x000EA5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x000EC3FC File Offset: 0x000EA5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 58U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.eINBMKMCFIA_.AddEntriesFrom(ref input, GetRogueExhibitionScRsp._repeated_eINBMKMCFIA_codec);
						}
					}
					else
					{
						this.aNEOFHIKDGK_.AddEntriesFrom(ref input, GetRogueExhibitionScRsp._repeated_aNEOFHIKDGK_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400226C RID: 8812
		private static readonly MessageParser<GetRogueExhibitionScRsp> _parser = new MessageParser<GetRogueExhibitionScRsp>(() => new GetRogueExhibitionScRsp());

		// Token: 0x0400226D RID: 8813
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400226E RID: 8814
		public const int EINBMKMCFIAFieldNumber = 11;

		// Token: 0x0400226F RID: 8815
		private static readonly FieldCodec<BHOFJLLBKNB> _repeated_eINBMKMCFIA_codec = FieldCodec.ForMessage<BHOFJLLBKNB>(90U, BHOFJLLBKNB.Parser);

		// Token: 0x04002270 RID: 8816
		private readonly RepeatedField<BHOFJLLBKNB> eINBMKMCFIA_ = new RepeatedField<BHOFJLLBKNB>();

		// Token: 0x04002271 RID: 8817
		public const int ANEOFHIKDGKFieldNumber = 7;

		// Token: 0x04002272 RID: 8818
		private static readonly FieldCodec<IBFALCFDLDG> _repeated_aNEOFHIKDGK_codec = FieldCodec.ForMessage<IBFALCFDLDG>(58U, IBFALCFDLDG.Parser);

		// Token: 0x04002273 RID: 8819
		private readonly RepeatedField<IBFALCFDLDG> aNEOFHIKDGK_ = new RepeatedField<IBFALCFDLDG>();

		// Token: 0x04002274 RID: 8820
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04002275 RID: 8821
		private uint retcode_;
	}
}
