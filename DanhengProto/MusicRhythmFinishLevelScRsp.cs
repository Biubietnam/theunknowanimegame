using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BDF RID: 3039
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmFinishLevelScRsp : IMessage<MusicRhythmFinishLevelScRsp>, IMessage, IEquatable<MusicRhythmFinishLevelScRsp>, IDeepCloneable<MusicRhythmFinishLevelScRsp>, IBufferMessage
	{
		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x06008681 RID: 34433 RVA: 0x00163151 File Offset: 0x00161351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmFinishLevelScRsp> Parser
		{
			get
			{
				return MusicRhythmFinishLevelScRsp._parser;
			}
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x06008682 RID: 34434 RVA: 0x00163158 File Offset: 0x00161358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmFinishLevelScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x06008683 RID: 34435 RVA: 0x0016316A File Offset: 0x0016136A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmFinishLevelScRsp.Descriptor;
			}
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x00163171 File Offset: 0x00161371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmFinishLevelScRsp()
		{
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x00163179 File Offset: 0x00161379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmFinishLevelScRsp(MusicRhythmFinishLevelScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008686 RID: 34438 RVA: 0x001631AA File Offset: 0x001613AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmFinishLevelScRsp Clone()
		{
			return new MusicRhythmFinishLevelScRsp(this);
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x06008687 RID: 34439 RVA: 0x001631B2 File Offset: 0x001613B2
		// (set) Token: 0x06008688 RID: 34440 RVA: 0x001631BA File Offset: 0x001613BA
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

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x06008689 RID: 34441 RVA: 0x001631C3 File Offset: 0x001613C3
		// (set) Token: 0x0600868A RID: 34442 RVA: 0x001631CB File Offset: 0x001613CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x001631D4 File Offset: 0x001613D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmFinishLevelScRsp);
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x001631E2 File Offset: 0x001613E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmFinishLevelScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x00163220 File Offset: 0x00161420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x00163278 File Offset: 0x00161478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x00163280 File Offset: 0x00161480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x0016328C File Offset: 0x0016148C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LevelId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x001632E8 File Offset: 0x001614E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x00163340 File Offset: 0x00161540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmFinishLevelScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x00163390 File Offset: 0x00161590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x0016339C File Offset: 0x0016159C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400338A RID: 13194
		private static readonly MessageParser<MusicRhythmFinishLevelScRsp> _parser = new MessageParser<MusicRhythmFinishLevelScRsp>(() => new MusicRhythmFinishLevelScRsp());

		// Token: 0x0400338B RID: 13195
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400338C RID: 13196
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400338D RID: 13197
		private uint retcode_;

		// Token: 0x0400338E RID: 13198
		public const int LevelIdFieldNumber = 4;

		// Token: 0x0400338F RID: 13199
		private uint levelId_;
	}
}
