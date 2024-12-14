using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001241 RID: 4673
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingResumeGameCsReq : IMessage<SwordTrainingResumeGameCsReq>, IMessage, IEquatable<SwordTrainingResumeGameCsReq>, IDeepCloneable<SwordTrainingResumeGameCsReq>, IBufferMessage
	{
		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0600D0B3 RID: 53427 RVA: 0x0022EA35 File Offset: 0x0022CC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingResumeGameCsReq> Parser
		{
			get
			{
				return SwordTrainingResumeGameCsReq._parser;
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0600D0B4 RID: 53428 RVA: 0x0022EA3C File Offset: 0x0022CC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingResumeGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x0600D0B5 RID: 53429 RVA: 0x0022EA4E File Offset: 0x0022CC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingResumeGameCsReq.Descriptor;
			}
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x0022EA55 File Offset: 0x0022CC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingResumeGameCsReq()
		{
		}

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x0022EA5D File Offset: 0x0022CC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingResumeGameCsReq(SwordTrainingResumeGameCsReq other) : this()
		{
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x0022EA82 File Offset: 0x0022CC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingResumeGameCsReq Clone()
		{
			return new SwordTrainingResumeGameCsReq(this);
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x0600D0B9 RID: 53433 RVA: 0x0022EA8A File Offset: 0x0022CC8A
		// (set) Token: 0x0600D0BA RID: 53434 RVA: 0x0022EA92 File Offset: 0x0022CC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStoryLineId
		{
			get
			{
				return this.gameStoryLineId_;
			}
			set
			{
				this.gameStoryLineId_ = value;
			}
		}

		// Token: 0x0600D0BB RID: 53435 RVA: 0x0022EA9B File Offset: 0x0022CC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingResumeGameCsReq);
		}

		// Token: 0x0600D0BC RID: 53436 RVA: 0x0022EAA9 File Offset: 0x0022CCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingResumeGameCsReq other)
		{
			return other != null && (other == this || (this.GameStoryLineId == other.GameStoryLineId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0BD RID: 53437 RVA: 0x0022EAD8 File Offset: 0x0022CCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x0022EB17 File Offset: 0x0022CD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x0022EB1F File Offset: 0x0022CD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0C0 RID: 53440 RVA: 0x0022EB28 File Offset: 0x0022CD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x0022EB5C File Offset: 0x0022CD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0C2 RID: 53442 RVA: 0x0022EB9A File Offset: 0x0022CD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingResumeGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x0022EBCB File Offset: 0x0022CDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x0022EBD4 File Offset: 0x0022CDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GameStoryLineId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053D6 RID: 21462
		private static readonly MessageParser<SwordTrainingResumeGameCsReq> _parser = new MessageParser<SwordTrainingResumeGameCsReq>(() => new SwordTrainingResumeGameCsReq());

		// Token: 0x040053D7 RID: 21463
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053D8 RID: 21464
		public const int GameStoryLineIdFieldNumber = 5;

		// Token: 0x040053D9 RID: 21465
		private uint gameStoryLineId_;
	}
}
