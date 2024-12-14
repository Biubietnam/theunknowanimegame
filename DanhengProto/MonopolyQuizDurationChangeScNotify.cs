using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B65 RID: 2917
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyQuizDurationChangeScNotify : IMessage<MonopolyQuizDurationChangeScNotify>, IMessage, IEquatable<MonopolyQuizDurationChangeScNotify>, IDeepCloneable<MonopolyQuizDurationChangeScNotify>, IBufferMessage
	{
		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x001545C5 File Offset: 0x001527C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyQuizDurationChangeScNotify> Parser
		{
			get
			{
				return MonopolyQuizDurationChangeScNotify._parser;
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x06008118 RID: 33048 RVA: 0x001545CC File Offset: 0x001527CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyQuizDurationChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x06008119 RID: 33049 RVA: 0x001545DE File Offset: 0x001527DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyQuizDurationChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600811A RID: 33050 RVA: 0x001545E5 File Offset: 0x001527E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyQuizDurationChangeScNotify()
		{
		}

		// Token: 0x0600811B RID: 33051 RVA: 0x001545F8 File Offset: 0x001527F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyQuizDurationChangeScNotify(MonopolyQuizDurationChangeScNotify other) : this()
		{
			this.hNLFBMPHEIL_ = other.hNLFBMPHEIL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x00154622 File Offset: 0x00152822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyQuizDurationChangeScNotify Clone()
		{
			return new MonopolyQuizDurationChangeScNotify(this);
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x0600811D RID: 33053 RVA: 0x0015462A File Offset: 0x0015282A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IDKFKMDHOEA> HNLFBMPHEIL
		{
			get
			{
				return this.hNLFBMPHEIL_;
			}
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00154632 File Offset: 0x00152832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyQuizDurationChangeScNotify);
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x00154640 File Offset: 0x00152840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyQuizDurationChangeScNotify other)
		{
			return other != null && (other == this || (this.hNLFBMPHEIL_.Equals(other.hNLFBMPHEIL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x00154674 File Offset: 0x00152874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hNLFBMPHEIL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008121 RID: 33057 RVA: 0x001546A8 File Offset: 0x001528A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008122 RID: 33058 RVA: 0x001546B0 File Offset: 0x001528B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x001546B9 File Offset: 0x001528B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hNLFBMPHEIL_.WriteTo(ref output, MonopolyQuizDurationChangeScNotify._repeated_hNLFBMPHEIL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x001546E0 File Offset: 0x001528E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hNLFBMPHEIL_.CalculateSize(MonopolyQuizDurationChangeScNotify._repeated_hNLFBMPHEIL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00154719 File Offset: 0x00152919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyQuizDurationChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.hNLFBMPHEIL_.Add(other.hNLFBMPHEIL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00154747 File Offset: 0x00152947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00154750 File Offset: 0x00152950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hNLFBMPHEIL_.AddEntriesFrom(ref input, MonopolyQuizDurationChangeScNotify._repeated_hNLFBMPHEIL_codec);
				}
			}
		}

		// Token: 0x0400314E RID: 12622
		private static readonly MessageParser<MonopolyQuizDurationChangeScNotify> _parser = new MessageParser<MonopolyQuizDurationChangeScNotify>(() => new MonopolyQuizDurationChangeScNotify());

		// Token: 0x0400314F RID: 12623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003150 RID: 12624
		public const int HNLFBMPHEILFieldNumber = 6;

		// Token: 0x04003151 RID: 12625
		private static readonly FieldCodec<IDKFKMDHOEA> _repeated_hNLFBMPHEIL_codec = FieldCodec.ForMessage<IDKFKMDHOEA>(50U, IDKFKMDHOEA.Parser);

		// Token: 0x04003152 RID: 12626
		private readonly RepeatedField<IDKFKMDHOEA> hNLFBMPHEIL_ = new RepeatedField<IDKFKMDHOEA>();
	}
}
