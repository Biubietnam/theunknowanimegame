using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200132D RID: 4909
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueMiracleHandbookRewardCsReq : IMessage<TakeRogueMiracleHandbookRewardCsReq>, IMessage, IEquatable<TakeRogueMiracleHandbookRewardCsReq>, IDeepCloneable<TakeRogueMiracleHandbookRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600DB0E RID: 56078 RVA: 0x002477D5 File Offset: 0x002459D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueMiracleHandbookRewardCsReq> Parser
		{
			get
			{
				return TakeRogueMiracleHandbookRewardCsReq._parser;
			}
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600DB0F RID: 56079 RVA: 0x002477DC File Offset: 0x002459DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueMiracleHandbookRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x0600DB10 RID: 56080 RVA: 0x002477EE File Offset: 0x002459EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueMiracleHandbookRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DB11 RID: 56081 RVA: 0x002477F5 File Offset: 0x002459F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueMiracleHandbookRewardCsReq()
		{
		}

		// Token: 0x0600DB12 RID: 56082 RVA: 0x00247808 File Offset: 0x00245A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueMiracleHandbookRewardCsReq(TakeRogueMiracleHandbookRewardCsReq other) : this()
		{
			this.handbookBuffList_ = other.handbookBuffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB13 RID: 56083 RVA: 0x00247832 File Offset: 0x00245A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueMiracleHandbookRewardCsReq Clone()
		{
			return new TakeRogueMiracleHandbookRewardCsReq(this);
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x0600DB14 RID: 56084 RVA: 0x0024783A File Offset: 0x00245A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HandbookBuffList
		{
			get
			{
				return this.handbookBuffList_;
			}
		}

		// Token: 0x0600DB15 RID: 56085 RVA: 0x00247842 File Offset: 0x00245A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueMiracleHandbookRewardCsReq);
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00247850 File Offset: 0x00245A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueMiracleHandbookRewardCsReq other)
		{
			return other != null && (other == this || (this.handbookBuffList_.Equals(other.handbookBuffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x00247884 File Offset: 0x00245A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.handbookBuffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x002478B8 File Offset: 0x00245AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x002478C0 File Offset: 0x00245AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x002478C9 File Offset: 0x00245AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.handbookBuffList_.WriteTo(ref output, TakeRogueMiracleHandbookRewardCsReq._repeated_handbookBuffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB1B RID: 56091 RVA: 0x002478F0 File Offset: 0x00245AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.handbookBuffList_.CalculateSize(TakeRogueMiracleHandbookRewardCsReq._repeated_handbookBuffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00247929 File Offset: 0x00245B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueMiracleHandbookRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.handbookBuffList_.Add(other.handbookBuffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB1D RID: 56093 RVA: 0x00247957 File Offset: 0x00245B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB1E RID: 56094 RVA: 0x00247960 File Offset: 0x00245B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.handbookBuffList_.AddEntriesFrom(ref input, TakeRogueMiracleHandbookRewardCsReq._repeated_handbookBuffList_codec);
				}
			}
		}

		// Token: 0x0400573A RID: 22330
		private static readonly MessageParser<TakeRogueMiracleHandbookRewardCsReq> _parser = new MessageParser<TakeRogueMiracleHandbookRewardCsReq>(() => new TakeRogueMiracleHandbookRewardCsReq());

		// Token: 0x0400573B RID: 22331
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400573C RID: 22332
		public const int HandbookBuffListFieldNumber = 3;

		// Token: 0x0400573D RID: 22333
		private static readonly FieldCodec<uint> _repeated_handbookBuffList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x0400573E RID: 22334
		private readonly RepeatedField<uint> handbookBuffList_ = new RepeatedField<uint>();
	}
}
