using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200112D RID: 4397
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetRogueExhibitionScRsp : IMessage<SetRogueExhibitionScRsp>, IMessage, IEquatable<SetRogueExhibitionScRsp>, IDeepCloneable<SetRogueExhibitionScRsp>, IBufferMessage
	{
		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600C416 RID: 50198 RVA: 0x0020E6BF File Offset: 0x0020C8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetRogueExhibitionScRsp> Parser
		{
			get
			{
				return SetRogueExhibitionScRsp._parser;
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600C417 RID: 50199 RVA: 0x0020E6C6 File Offset: 0x0020C8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetRogueExhibitionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600C418 RID: 50200 RVA: 0x0020E6D8 File Offset: 0x0020C8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetRogueExhibitionScRsp.Descriptor;
			}
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x0020E6DF File Offset: 0x0020C8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueExhibitionScRsp()
		{
		}

		// Token: 0x0600C41A RID: 50202 RVA: 0x0020E700 File Offset: 0x0020C900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueExhibitionScRsp(SetRogueExhibitionScRsp other) : this()
		{
			this.eINBMKMCFIA_ = other.eINBMKMCFIA_.Clone();
			this.retcode_ = other.retcode_;
			this.aNEOFHIKDGK_ = other.aNEOFHIKDGK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C41B RID: 50203 RVA: 0x0020E752 File Offset: 0x0020C952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueExhibitionScRsp Clone()
		{
			return new SetRogueExhibitionScRsp(this);
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600C41C RID: 50204 RVA: 0x0020E75A File Offset: 0x0020C95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BHOFJLLBKNB> EINBMKMCFIA
		{
			get
			{
				return this.eINBMKMCFIA_;
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600C41D RID: 50205 RVA: 0x0020E762 File Offset: 0x0020C962
		// (set) Token: 0x0600C41E RID: 50206 RVA: 0x0020E76A File Offset: 0x0020C96A
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

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600C41F RID: 50207 RVA: 0x0020E773 File Offset: 0x0020C973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IBFALCFDLDG> ANEOFHIKDGK
		{
			get
			{
				return this.aNEOFHIKDGK_;
			}
		}

		// Token: 0x0600C420 RID: 50208 RVA: 0x0020E77B File Offset: 0x0020C97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetRogueExhibitionScRsp);
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x0020E78C File Offset: 0x0020C98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetRogueExhibitionScRsp other)
		{
			return other != null && (other == this || (this.eINBMKMCFIA_.Equals(other.eINBMKMCFIA_) && this.Retcode == other.Retcode && this.aNEOFHIKDGK_.Equals(other.aNEOFHIKDGK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C422 RID: 50210 RVA: 0x0020E7F0 File Offset: 0x0020C9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.eINBMKMCFIA_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.aNEOFHIKDGK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x0020E84B File Offset: 0x0020CA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C424 RID: 50212 RVA: 0x0020E853 File Offset: 0x0020CA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C425 RID: 50213 RVA: 0x0020E85C File Offset: 0x0020CA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.eINBMKMCFIA_.WriteTo(ref output, SetRogueExhibitionScRsp._repeated_eINBMKMCFIA_codec);
			this.aNEOFHIKDGK_.WriteTo(ref output, SetRogueExhibitionScRsp._repeated_aNEOFHIKDGK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C426 RID: 50214 RVA: 0x0020E8BC File Offset: 0x0020CABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eINBMKMCFIA_.CalculateSize(SetRogueExhibitionScRsp._repeated_eINBMKMCFIA_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.aNEOFHIKDGK_.CalculateSize(SetRogueExhibitionScRsp._repeated_aNEOFHIKDGK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C427 RID: 50215 RVA: 0x0020E920 File Offset: 0x0020CB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetRogueExhibitionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.eINBMKMCFIA_.Add(other.eINBMKMCFIA_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.aNEOFHIKDGK_.Add(other.aNEOFHIKDGK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C428 RID: 50216 RVA: 0x0020E97E File Offset: 0x0020CB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C429 RID: 50217 RVA: 0x0020E988 File Offset: 0x0020CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 106U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.aNEOFHIKDGK_.AddEntriesFrom(ref input, SetRogueExhibitionScRsp._repeated_aNEOFHIKDGK_codec);
						}
					}
					else
					{
						this.eINBMKMCFIA_.AddEntriesFrom(ref input, SetRogueExhibitionScRsp._repeated_eINBMKMCFIA_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004F41 RID: 20289
		private static readonly MessageParser<SetRogueExhibitionScRsp> _parser = new MessageParser<SetRogueExhibitionScRsp>(() => new SetRogueExhibitionScRsp());

		// Token: 0x04004F42 RID: 20290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F43 RID: 20291
		public const int EINBMKMCFIAFieldNumber = 13;

		// Token: 0x04004F44 RID: 20292
		private static readonly FieldCodec<BHOFJLLBKNB> _repeated_eINBMKMCFIA_codec = FieldCodec.ForMessage<BHOFJLLBKNB>(106U, BHOFJLLBKNB.Parser);

		// Token: 0x04004F45 RID: 20293
		private readonly RepeatedField<BHOFJLLBKNB> eINBMKMCFIA_ = new RepeatedField<BHOFJLLBKNB>();

		// Token: 0x04004F46 RID: 20294
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04004F47 RID: 20295
		private uint retcode_;

		// Token: 0x04004F48 RID: 20296
		public const int ANEOFHIKDGKFieldNumber = 14;

		// Token: 0x04004F49 RID: 20297
		private static readonly FieldCodec<IBFALCFDLDG> _repeated_aNEOFHIKDGK_codec = FieldCodec.ForMessage<IBFALCFDLDG>(114U, IBFALCFDLDG.Parser);

		// Token: 0x04004F4A RID: 20298
		private readonly RepeatedField<IBFALCFDLDG> aNEOFHIKDGK_ = new RepeatedField<IBFALCFDLDG>();
	}
}
