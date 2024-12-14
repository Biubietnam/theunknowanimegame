using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200124D RID: 4685
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingStartGameCsReq : IMessage<SwordTrainingStartGameCsReq>, IMessage, IEquatable<SwordTrainingStartGameCsReq>, IDeepCloneable<SwordTrainingStartGameCsReq>, IBufferMessage
	{
		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0600D137 RID: 53559 RVA: 0x0022FB88 File Offset: 0x0022DD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingStartGameCsReq> Parser
		{
			get
			{
				return SwordTrainingStartGameCsReq._parser;
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0600D138 RID: 53560 RVA: 0x0022FB8F File Offset: 0x0022DD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStartGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0600D139 RID: 53561 RVA: 0x0022FBA1 File Offset: 0x0022DDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingStartGameCsReq.Descriptor;
			}
		}

		// Token: 0x0600D13A RID: 53562 RVA: 0x0022FBA8 File Offset: 0x0022DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStartGameCsReq()
		{
		}

		// Token: 0x0600D13B RID: 53563 RVA: 0x0022FBB0 File Offset: 0x0022DDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStartGameCsReq(SwordTrainingStartGameCsReq other) : this()
		{
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D13C RID: 53564 RVA: 0x0022FBD5 File Offset: 0x0022DDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStartGameCsReq Clone()
		{
			return new SwordTrainingStartGameCsReq(this);
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x0600D13D RID: 53565 RVA: 0x0022FBDD File Offset: 0x0022DDDD
		// (set) Token: 0x0600D13E RID: 53566 RVA: 0x0022FBE5 File Offset: 0x0022DDE5
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

		// Token: 0x0600D13F RID: 53567 RVA: 0x0022FBEE File Offset: 0x0022DDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingStartGameCsReq);
		}

		// Token: 0x0600D140 RID: 53568 RVA: 0x0022FBFC File Offset: 0x0022DDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingStartGameCsReq other)
		{
			return other != null && (other == this || (this.GameStoryLineId == other.GameStoryLineId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D141 RID: 53569 RVA: 0x0022FC2C File Offset: 0x0022DE2C
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

		// Token: 0x0600D142 RID: 53570 RVA: 0x0022FC6B File Offset: 0x0022DE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x0022FC73 File Offset: 0x0022DE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D144 RID: 53572 RVA: 0x0022FC7C File Offset: 0x0022DE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D145 RID: 53573 RVA: 0x0022FCB0 File Offset: 0x0022DEB0
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

		// Token: 0x0600D146 RID: 53574 RVA: 0x0022FCEE File Offset: 0x0022DEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingStartGameCsReq other)
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

		// Token: 0x0600D147 RID: 53575 RVA: 0x0022FD1F File Offset: 0x0022DF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D148 RID: 53576 RVA: 0x0022FD28 File Offset: 0x0022DF28
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
					this.GameStoryLineId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053FA RID: 21498
		private static readonly MessageParser<SwordTrainingStartGameCsReq> _parser = new MessageParser<SwordTrainingStartGameCsReq>(() => new SwordTrainingStartGameCsReq());

		// Token: 0x040053FB RID: 21499
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053FC RID: 21500
		public const int GameStoryLineIdFieldNumber = 6;

		// Token: 0x040053FD RID: 21501
		private uint gameStoryLineId_;
	}
}
