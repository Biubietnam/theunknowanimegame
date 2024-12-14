using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E11 RID: 3601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBonusSelectInfo : IMessage<RogueBonusSelectInfo>, IMessage, IEquatable<RogueBonusSelectInfo>, IDeepCloneable<RogueBonusSelectInfo>, IBufferMessage
	{
		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600A0ED RID: 41197 RVA: 0x001AFA60 File Offset: 0x001ADC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBonusSelectInfo> Parser
		{
			get
			{
				return RogueBonusSelectInfo._parser;
			}
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0600A0EE RID: 41198 RVA: 0x001AFA67 File Offset: 0x001ADC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBonusSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0600A0EF RID: 41199 RVA: 0x001AFA79 File Offset: 0x001ADC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBonusSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x001AFA80 File Offset: 0x001ADC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectInfo()
		{
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x001AFA93 File Offset: 0x001ADC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectInfo(RogueBonusSelectInfo other) : this()
		{
			this.bonusIdList_ = other.bonusIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x001AFABD File Offset: 0x001ADCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectInfo Clone()
		{
			return new RogueBonusSelectInfo(this);
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0600A0F3 RID: 41203 RVA: 0x001AFAC5 File Offset: 0x001ADCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BonusIdList
		{
			get
			{
				return this.bonusIdList_;
			}
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x001AFACD File Offset: 0x001ADCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBonusSelectInfo);
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x001AFADB File Offset: 0x001ADCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBonusSelectInfo other)
		{
			return other != null && (other == this || (this.bonusIdList_.Equals(other.bonusIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x001AFB10 File Offset: 0x001ADD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bonusIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x001AFB44 File Offset: 0x001ADD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x001AFB4C File Offset: 0x001ADD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x001AFB55 File Offset: 0x001ADD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bonusIdList_.WriteTo(ref output, RogueBonusSelectInfo._repeated_bonusIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x001AFB7C File Offset: 0x001ADD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bonusIdList_.CalculateSize(RogueBonusSelectInfo._repeated_bonusIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x001AFBB5 File Offset: 0x001ADDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBonusSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.bonusIdList_.Add(other.bonusIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x001AFBE3 File Offset: 0x001ADDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x001AFBEC File Offset: 0x001ADDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bonusIdList_.AddEntriesFrom(ref input, RogueBonusSelectInfo._repeated_bonusIdList_codec);
				}
			}
		}

		// Token: 0x040041E6 RID: 16870
		private static readonly MessageParser<RogueBonusSelectInfo> _parser = new MessageParser<RogueBonusSelectInfo>(() => new RogueBonusSelectInfo());

		// Token: 0x040041E7 RID: 16871
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E8 RID: 16872
		public const int BonusIdListFieldNumber = 13;

		// Token: 0x040041E9 RID: 16873
		private static readonly FieldCodec<uint> _repeated_bonusIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x040041EA RID: 16874
		private readonly RepeatedField<uint> bonusIdList_ = new RepeatedField<uint>();
	}
}
