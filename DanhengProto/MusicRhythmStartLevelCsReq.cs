using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BEB RID: 3051
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmStartLevelCsReq : IMessage<MusicRhythmStartLevelCsReq>, IMessage, IEquatable<MusicRhythmStartLevelCsReq>, IDeepCloneable<MusicRhythmStartLevelCsReq>, IBufferMessage
	{
		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x0600870B RID: 34571 RVA: 0x00164598 File Offset: 0x00162798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmStartLevelCsReq> Parser
		{
			get
			{
				return MusicRhythmStartLevelCsReq._parser;
			}
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x0600870C RID: 34572 RVA: 0x0016459F File Offset: 0x0016279F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmStartLevelCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x0600870D RID: 34573 RVA: 0x001645B1 File Offset: 0x001627B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmStartLevelCsReq.Descriptor;
			}
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x001645B8 File Offset: 0x001627B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmStartLevelCsReq()
		{
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x001645C0 File Offset: 0x001627C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmStartLevelCsReq(MusicRhythmStartLevelCsReq other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x001645E5 File Offset: 0x001627E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmStartLevelCsReq Clone()
		{
			return new MusicRhythmStartLevelCsReq(this);
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x06008711 RID: 34577 RVA: 0x001645ED File Offset: 0x001627ED
		// (set) Token: 0x06008712 RID: 34578 RVA: 0x001645F5 File Offset: 0x001627F5
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

		// Token: 0x06008713 RID: 34579 RVA: 0x001645FE File Offset: 0x001627FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmStartLevelCsReq);
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x0016460C File Offset: 0x0016280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmStartLevelCsReq other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x0016463C File Offset: 0x0016283C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06008716 RID: 34582 RVA: 0x0016467B File Offset: 0x0016287B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x00164683 File Offset: 0x00162883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x0016468C File Offset: 0x0016288C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x001646C0 File Offset: 0x001628C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600871A RID: 34586 RVA: 0x001646FE File Offset: 0x001628FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmStartLevelCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x0016472F File Offset: 0x0016292F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x00164738 File Offset: 0x00162938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040033B8 RID: 13240
		private static readonly MessageParser<MusicRhythmStartLevelCsReq> _parser = new MessageParser<MusicRhythmStartLevelCsReq>(() => new MusicRhythmStartLevelCsReq());

		// Token: 0x040033B9 RID: 13241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033BA RID: 13242
		public const int LevelIdFieldNumber = 3;

		// Token: 0x040033BB RID: 13243
		private uint levelId_;
	}
}
