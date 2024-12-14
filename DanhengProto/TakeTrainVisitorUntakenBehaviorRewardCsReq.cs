using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200133D RID: 4925
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeTrainVisitorUntakenBehaviorRewardCsReq : IMessage<TakeTrainVisitorUntakenBehaviorRewardCsReq>, IMessage, IEquatable<TakeTrainVisitorUntakenBehaviorRewardCsReq>, IDeepCloneable<TakeTrainVisitorUntakenBehaviorRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600DBCB RID: 56267 RVA: 0x002496AD File Offset: 0x002478AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeTrainVisitorUntakenBehaviorRewardCsReq> Parser
		{
			get
			{
				return TakeTrainVisitorUntakenBehaviorRewardCsReq._parser;
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600DBCC RID: 56268 RVA: 0x002496B4 File Offset: 0x002478B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeTrainVisitorUntakenBehaviorRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600DBCD RID: 56269 RVA: 0x002496C6 File Offset: 0x002478C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeTrainVisitorUntakenBehaviorRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DBCE RID: 56270 RVA: 0x002496CD File Offset: 0x002478CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrainVisitorUntakenBehaviorRewardCsReq()
		{
		}

		// Token: 0x0600DBCF RID: 56271 RVA: 0x002496D5 File Offset: 0x002478D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrainVisitorUntakenBehaviorRewardCsReq(TakeTrainVisitorUntakenBehaviorRewardCsReq other) : this()
		{
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBD0 RID: 56272 RVA: 0x002496FA File Offset: 0x002478FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrainVisitorUntakenBehaviorRewardCsReq Clone()
		{
			return new TakeTrainVisitorUntakenBehaviorRewardCsReq(this);
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600DBD1 RID: 56273 RVA: 0x00249702 File Offset: 0x00247902
		// (set) Token: 0x0600DBD2 RID: 56274 RVA: 0x0024970A File Offset: 0x0024790A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJLKCHKMNMI
		{
			get
			{
				return this.dJLKCHKMNMI_;
			}
			set
			{
				this.dJLKCHKMNMI_ = value;
			}
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x00249713 File Offset: 0x00247913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeTrainVisitorUntakenBehaviorRewardCsReq);
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x00249721 File Offset: 0x00247921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeTrainVisitorUntakenBehaviorRewardCsReq other)
		{
			return other != null && (other == this || (this.DJLKCHKMNMI == other.DJLKCHKMNMI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x00249750 File Offset: 0x00247950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x0024978F File Offset: 0x0024798F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DBD7 RID: 56279 RVA: 0x00249797 File Offset: 0x00247997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBD8 RID: 56280 RVA: 0x002497A0 File Offset: 0x002479A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBD9 RID: 56281 RVA: 0x002497D4 File Offset: 0x002479D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBDA RID: 56282 RVA: 0x00249812 File Offset: 0x00247A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeTrainVisitorUntakenBehaviorRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBDB RID: 56283 RVA: 0x00249843 File Offset: 0x00247A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBDC RID: 56284 RVA: 0x0024984C File Offset: 0x00247A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DJLKCHKMNMI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400577D RID: 22397
		private static readonly MessageParser<TakeTrainVisitorUntakenBehaviorRewardCsReq> _parser = new MessageParser<TakeTrainVisitorUntakenBehaviorRewardCsReq>(() => new TakeTrainVisitorUntakenBehaviorRewardCsReq());

		// Token: 0x0400577E RID: 22398
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400577F RID: 22399
		public const int DJLKCHKMNMIFieldNumber = 6;

		// Token: 0x04005780 RID: 22400
		private uint dJLKCHKMNMI_;
	}
}
