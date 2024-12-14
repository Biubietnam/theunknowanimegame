using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001341 RID: 4929
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeTrialActivityRewardCsReq : IMessage<TakeTrialActivityRewardCsReq>, IMessage, IEquatable<TakeTrialActivityRewardCsReq>, IDeepCloneable<TakeTrialActivityRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600DBF8 RID: 56312 RVA: 0x00249D3C File Offset: 0x00247F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeTrialActivityRewardCsReq> Parser
		{
			get
			{
				return TakeTrialActivityRewardCsReq._parser;
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0600DBF9 RID: 56313 RVA: 0x00249D43 File Offset: 0x00247F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeTrialActivityRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x00249D55 File Offset: 0x00247F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeTrialActivityRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DBFB RID: 56315 RVA: 0x00249D5C File Offset: 0x00247F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrialActivityRewardCsReq()
		{
		}

		// Token: 0x0600DBFC RID: 56316 RVA: 0x00249D64 File Offset: 0x00247F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrialActivityRewardCsReq(TakeTrialActivityRewardCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBFD RID: 56317 RVA: 0x00249D89 File Offset: 0x00247F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrialActivityRewardCsReq Clone()
		{
			return new TakeTrialActivityRewardCsReq(this);
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0600DBFE RID: 56318 RVA: 0x00249D91 File Offset: 0x00247F91
		// (set) Token: 0x0600DBFF RID: 56319 RVA: 0x00249D99 File Offset: 0x00247F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x0600DC00 RID: 56320 RVA: 0x00249DA2 File Offset: 0x00247FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeTrialActivityRewardCsReq);
		}

		// Token: 0x0600DC01 RID: 56321 RVA: 0x00249DB0 File Offset: 0x00247FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeTrialActivityRewardCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC02 RID: 56322 RVA: 0x00249DE0 File Offset: 0x00247FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC03 RID: 56323 RVA: 0x00249E1F File Offset: 0x0024801F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DC04 RID: 56324 RVA: 0x00249E27 File Offset: 0x00248027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC05 RID: 56325 RVA: 0x00249E30 File Offset: 0x00248030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC06 RID: 56326 RVA: 0x00249E64 File Offset: 0x00248064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC07 RID: 56327 RVA: 0x00249EA2 File Offset: 0x002480A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeTrialActivityRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC08 RID: 56328 RVA: 0x00249ED3 File Offset: 0x002480D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC09 RID: 56329 RVA: 0x00249EDC File Offset: 0x002480DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400578C RID: 22412
		private static readonly MessageParser<TakeTrialActivityRewardCsReq> _parser = new MessageParser<TakeTrialActivityRewardCsReq>(() => new TakeTrialActivityRewardCsReq());

		// Token: 0x0400578D RID: 22413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400578E RID: 22414
		public const int StageIdFieldNumber = 10;

		// Token: 0x0400578F RID: 22415
		private uint stageId_;
	}
}
