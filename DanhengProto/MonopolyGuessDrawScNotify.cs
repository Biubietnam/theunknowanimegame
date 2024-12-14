using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B59 RID: 2905
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGuessDrawScNotify : IMessage<MonopolyGuessDrawScNotify>, IMessage, IEquatable<MonopolyGuessDrawScNotify>, IDeepCloneable<MonopolyGuessDrawScNotify>, IBufferMessage
	{
		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x06008090 RID: 32912 RVA: 0x001531B9 File Offset: 0x001513B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGuessDrawScNotify> Parser
		{
			get
			{
				return MonopolyGuessDrawScNotify._parser;
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x001531C0 File Offset: 0x001513C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGuessDrawScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x06008092 RID: 32914 RVA: 0x001531D2 File Offset: 0x001513D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGuessDrawScNotify.Descriptor;
			}
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x001531D9 File Offset: 0x001513D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessDrawScNotify()
		{
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x001531EC File Offset: 0x001513EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessDrawScNotify(MonopolyGuessDrawScNotify other) : this()
		{
			this.kJMMGCGMFCK_ = other.kJMMGCGMFCK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x00153216 File Offset: 0x00151416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessDrawScNotify Clone()
		{
			return new MonopolyGuessDrawScNotify(this);
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x06008096 RID: 32918 RVA: 0x0015321E File Offset: 0x0015141E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JHNBALHMPDJ> KJMMGCGMFCK
		{
			get
			{
				return this.kJMMGCGMFCK_;
			}
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x00153226 File Offset: 0x00151426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGuessDrawScNotify);
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x00153234 File Offset: 0x00151434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGuessDrawScNotify other)
		{
			return other != null && (other == this || (this.kJMMGCGMFCK_.Equals(other.kJMMGCGMFCK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x00153268 File Offset: 0x00151468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kJMMGCGMFCK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x0015329C File Offset: 0x0015149C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x001532A4 File Offset: 0x001514A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x001532AD File Offset: 0x001514AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kJMMGCGMFCK_.WriteTo(ref output, MonopolyGuessDrawScNotify._repeated_kJMMGCGMFCK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x001532D4 File Offset: 0x001514D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kJMMGCGMFCK_.CalculateSize(MonopolyGuessDrawScNotify._repeated_kJMMGCGMFCK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x0015330D File Offset: 0x0015150D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGuessDrawScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.kJMMGCGMFCK_.Add(other.kJMMGCGMFCK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x0015333B File Offset: 0x0015153B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x00153344 File Offset: 0x00151544
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
					this.kJMMGCGMFCK_.AddEntriesFrom(ref input, MonopolyGuessDrawScNotify._repeated_kJMMGCGMFCK_codec);
				}
			}
		}

		// Token: 0x04003121 RID: 12577
		private static readonly MessageParser<MonopolyGuessDrawScNotify> _parser = new MessageParser<MonopolyGuessDrawScNotify>(() => new MonopolyGuessDrawScNotify());

		// Token: 0x04003122 RID: 12578
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003123 RID: 12579
		public const int KJMMGCGMFCKFieldNumber = 6;

		// Token: 0x04003124 RID: 12580
		private static readonly FieldCodec<JHNBALHMPDJ> _repeated_kJMMGCGMFCK_codec = FieldCodec.ForMessage<JHNBALHMPDJ>(50U, JHNBALHMPDJ.Parser);

		// Token: 0x04003125 RID: 12581
		private readonly RepeatedField<JHNBALHMPDJ> kJMMGCGMFCK_ = new RepeatedField<JHNBALHMPDJ>();
	}
}
