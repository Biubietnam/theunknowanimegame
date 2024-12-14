using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200133F RID: 4927
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeTrainVisitorUntakenBehaviorRewardScRsp : IMessage<TakeTrainVisitorUntakenBehaviorRewardScRsp>, IMessage, IEquatable<TakeTrainVisitorUntakenBehaviorRewardScRsp>, IDeepCloneable<TakeTrainVisitorUntakenBehaviorRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0600DBE0 RID: 56288 RVA: 0x0024994B File Offset: 0x00247B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeTrainVisitorUntakenBehaviorRewardScRsp> Parser
		{
			get
			{
				return TakeTrainVisitorUntakenBehaviorRewardScRsp._parser;
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0600DBE1 RID: 56289 RVA: 0x00249952 File Offset: 0x00247B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeTrainVisitorUntakenBehaviorRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0600DBE2 RID: 56290 RVA: 0x00249964 File Offset: 0x00247B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeTrainVisitorUntakenBehaviorRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DBE3 RID: 56291 RVA: 0x0024996B File Offset: 0x00247B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrainVisitorUntakenBehaviorRewardScRsp()
		{
		}

		// Token: 0x0600DBE4 RID: 56292 RVA: 0x00249980 File Offset: 0x00247B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrainVisitorUntakenBehaviorRewardScRsp(TakeTrainVisitorUntakenBehaviorRewardScRsp other) : this()
		{
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this.retcode_ = other.retcode_;
			this.eCDLFEANJMA_ = other.eCDLFEANJMA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBE5 RID: 56293 RVA: 0x002499CD File Offset: 0x00247BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrainVisitorUntakenBehaviorRewardScRsp Clone()
		{
			return new TakeTrainVisitorUntakenBehaviorRewardScRsp(this);
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x0600DBE6 RID: 56294 RVA: 0x002499D5 File Offset: 0x00247BD5
		// (set) Token: 0x0600DBE7 RID: 56295 RVA: 0x002499DD File Offset: 0x00247BDD
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

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x0600DBE8 RID: 56296 RVA: 0x002499E6 File Offset: 0x00247BE6
		// (set) Token: 0x0600DBE9 RID: 56297 RVA: 0x002499EE File Offset: 0x00247BEE
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

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600DBEA RID: 56298 RVA: 0x002499F7 File Offset: 0x00247BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ECDLFEANJMA
		{
			get
			{
				return this.eCDLFEANJMA_;
			}
		}

		// Token: 0x0600DBEB RID: 56299 RVA: 0x002499FF File Offset: 0x00247BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeTrainVisitorUntakenBehaviorRewardScRsp);
		}

		// Token: 0x0600DBEC RID: 56300 RVA: 0x00249A10 File Offset: 0x00247C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeTrainVisitorUntakenBehaviorRewardScRsp other)
		{
			return other != null && (other == this || (this.DJLKCHKMNMI == other.DJLKCHKMNMI && this.Retcode == other.Retcode && this.eCDLFEANJMA_.Equals(other.eCDLFEANJMA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBED RID: 56301 RVA: 0x00249A70 File Offset: 0x00247C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.eCDLFEANJMA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBEE RID: 56302 RVA: 0x00249AD6 File Offset: 0x00247CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DBEF RID: 56303 RVA: 0x00249ADE File Offset: 0x00247CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x00249AE8 File Offset: 0x00247CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			this.eCDLFEANJMA_.WriteTo(ref output, TakeTrainVisitorUntakenBehaviorRewardScRsp._repeated_eCDLFEANJMA_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBF1 RID: 56305 RVA: 0x00249B54 File Offset: 0x00247D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.eCDLFEANJMA_.CalculateSize(TakeTrainVisitorUntakenBehaviorRewardScRsp._repeated_eCDLFEANJMA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBF2 RID: 56306 RVA: 0x00249BC0 File Offset: 0x00247DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeTrainVisitorUntakenBehaviorRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.eCDLFEANJMA_.Add(other.eCDLFEANJMA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBF3 RID: 56307 RVA: 0x00249C21 File Offset: 0x00247E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBF4 RID: 56308 RVA: 0x00249C2C File Offset: 0x00247E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.DJLKCHKMNMI = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.eCDLFEANJMA_.AddEntriesFrom(ref input, TakeTrainVisitorUntakenBehaviorRewardScRsp._repeated_eCDLFEANJMA_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005782 RID: 22402
		private static readonly MessageParser<TakeTrainVisitorUntakenBehaviorRewardScRsp> _parser = new MessageParser<TakeTrainVisitorUntakenBehaviorRewardScRsp>(() => new TakeTrainVisitorUntakenBehaviorRewardScRsp());

		// Token: 0x04005783 RID: 22403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005784 RID: 22404
		public const int DJLKCHKMNMIFieldNumber = 10;

		// Token: 0x04005785 RID: 22405
		private uint dJLKCHKMNMI_;

		// Token: 0x04005786 RID: 22406
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04005787 RID: 22407
		private uint retcode_;

		// Token: 0x04005788 RID: 22408
		public const int ECDLFEANJMAFieldNumber = 14;

		// Token: 0x04005789 RID: 22409
		private static readonly FieldCodec<uint> _repeated_eCDLFEANJMA_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x0400578A RID: 22410
		private readonly RepeatedField<uint> eCDLFEANJMA_ = new RepeatedField<uint>();
	}
}
