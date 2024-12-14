using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B03 RID: 2819
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyAcceptQuizCsReq : IMessage<MonopolyAcceptQuizCsReq>, IMessage, IEquatable<MonopolyAcceptQuizCsReq>, IDeepCloneable<MonopolyAcceptQuizCsReq>, IBufferMessage
	{
		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x0014A69D File Offset: 0x0014889D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyAcceptQuizCsReq> Parser
		{
			get
			{
				return MonopolyAcceptQuizCsReq._parser;
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x0014A6A4 File Offset: 0x001488A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyAcceptQuizCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x06007CC6 RID: 31942 RVA: 0x0014A6B6 File Offset: 0x001488B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyAcceptQuizCsReq.Descriptor;
			}
		}

		// Token: 0x06007CC7 RID: 31943 RVA: 0x0014A6BD File Offset: 0x001488BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyAcceptQuizCsReq()
		{
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x0014A6D0 File Offset: 0x001488D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyAcceptQuizCsReq(MonopolyAcceptQuizCsReq other) : this()
		{
			this.cDIICHMHBDL_ = other.cDIICHMHBDL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x0014A6FA File Offset: 0x001488FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyAcceptQuizCsReq Clone()
		{
			return new MonopolyAcceptQuizCsReq(this);
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06007CCA RID: 31946 RVA: 0x0014A702 File Offset: 0x00148902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KNNMIFKBOBO> CDIICHMHBDL
		{
			get
			{
				return this.cDIICHMHBDL_;
			}
		}

		// Token: 0x06007CCB RID: 31947 RVA: 0x0014A70A File Offset: 0x0014890A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyAcceptQuizCsReq);
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x0014A718 File Offset: 0x00148918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyAcceptQuizCsReq other)
		{
			return other != null && (other == this || (this.cDIICHMHBDL_.Equals(other.cDIICHMHBDL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x0014A74C File Offset: 0x0014894C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cDIICHMHBDL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x0014A780 File Offset: 0x00148980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x0014A788 File Offset: 0x00148988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x0014A791 File Offset: 0x00148991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cDIICHMHBDL_.WriteTo(ref output, MonopolyAcceptQuizCsReq._repeated_cDIICHMHBDL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x0014A7B8 File Offset: 0x001489B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cDIICHMHBDL_.CalculateSize(MonopolyAcceptQuizCsReq._repeated_cDIICHMHBDL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x0014A7F1 File Offset: 0x001489F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyAcceptQuizCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.cDIICHMHBDL_.Add(other.cDIICHMHBDL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x0014A81F File Offset: 0x00148A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x0014A828 File Offset: 0x00148A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cDIICHMHBDL_.AddEntriesFrom(ref input, MonopolyAcceptQuizCsReq._repeated_cDIICHMHBDL_codec);
				}
			}
		}

		// Token: 0x04002FF7 RID: 12279
		private static readonly MessageParser<MonopolyAcceptQuizCsReq> _parser = new MessageParser<MonopolyAcceptQuizCsReq>(() => new MonopolyAcceptQuizCsReq());

		// Token: 0x04002FF8 RID: 12280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF9 RID: 12281
		public const int CDIICHMHBDLFieldNumber = 14;

		// Token: 0x04002FFA RID: 12282
		private static readonly FieldCodec<KNNMIFKBOBO> _repeated_cDIICHMHBDL_codec = FieldCodec.ForMessage<KNNMIFKBOBO>(114U, KNNMIFKBOBO.Parser);

		// Token: 0x04002FFB RID: 12283
		private readonly RepeatedField<KNNMIFKBOBO> cDIICHMHBDL_ = new RepeatedField<KNNMIFKBOBO>();
	}
}
