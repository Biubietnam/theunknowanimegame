using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F0D RID: 3853
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterSelectInfo : IMessage<RogueMagicScepterSelectInfo>, IMessage, IEquatable<RogueMagicScepterSelectInfo>, IDeepCloneable<RogueMagicScepterSelectInfo>, IBufferMessage
	{
		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0600AC01 RID: 44033 RVA: 0x001CF0BF File Offset: 0x001CD2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterSelectInfo> Parser
		{
			get
			{
				return RogueMagicScepterSelectInfo._parser;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0600AC02 RID: 44034 RVA: 0x001CF0C6 File Offset: 0x001CD2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x001CF0D8 File Offset: 0x001CD2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600AC04 RID: 44036 RVA: 0x001CF0DF File Offset: 0x001CD2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectInfo()
		{
		}

		// Token: 0x0600AC05 RID: 44037 RVA: 0x001CF0F2 File Offset: 0x001CD2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectInfo(RogueMagicScepterSelectInfo other) : this()
		{
			this.selectScepters_ = other.selectScepters_.Clone();
			this.selectHintId_ = other.selectHintId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC06 RID: 44038 RVA: 0x001CF128 File Offset: 0x001CD328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectInfo Clone()
		{
			return new RogueMagicScepterSelectInfo(this);
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x001CF130 File Offset: 0x001CD330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicScepter> SelectScepters
		{
			get
			{
				return this.selectScepters_;
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0600AC08 RID: 44040 RVA: 0x001CF138 File Offset: 0x001CD338
		// (set) Token: 0x0600AC09 RID: 44041 RVA: 0x001CF140 File Offset: 0x001CD340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x0600AC0A RID: 44042 RVA: 0x001CF149 File Offset: 0x001CD349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterSelectInfo);
		}

		// Token: 0x0600AC0B RID: 44043 RVA: 0x001CF158 File Offset: 0x001CD358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterSelectInfo other)
		{
			return other != null && (other == this || (this.selectScepters_.Equals(other.selectScepters_) && this.SelectHintId == other.SelectHintId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x001CF1A8 File Offset: 0x001CD3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selectScepters_.GetHashCode();
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x001CF1F5 File Offset: 0x001CD3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x001CF1FD File Offset: 0x001CD3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x001CF208 File Offset: 0x001CD408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.SelectHintId);
			}
			this.selectScepters_.WriteTo(ref output, RogueMagicScepterSelectInfo._repeated_selectScepters_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x001CF258 File Offset: 0x001CD458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selectScepters_.CalculateSize(RogueMagicScepterSelectInfo._repeated_selectScepters_codec);
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC11 RID: 44049 RVA: 0x001CF2AC File Offset: 0x001CD4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.selectScepters_.Add(other.selectScepters_);
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x001CF2F9 File Offset: 0x001CD4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x001CF304 File Offset: 0x001CD504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.selectScepters_.AddEntriesFrom(ref input, RogueMagicScepterSelectInfo._repeated_selectScepters_codec);
					}
				}
				else
				{
					this.SelectHintId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004623 RID: 17955
		private static readonly MessageParser<RogueMagicScepterSelectInfo> _parser = new MessageParser<RogueMagicScepterSelectInfo>(() => new RogueMagicScepterSelectInfo());

		// Token: 0x04004624 RID: 17956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004625 RID: 17957
		public const int SelectSceptersFieldNumber = 11;

		// Token: 0x04004626 RID: 17958
		private static readonly FieldCodec<RogueMagicScepter> _repeated_selectScepters_codec = FieldCodec.ForMessage<RogueMagicScepter>(90U, RogueMagicScepter.Parser);

		// Token: 0x04004627 RID: 17959
		private readonly RepeatedField<RogueMagicScepter> selectScepters_ = new RepeatedField<RogueMagicScepter>();

		// Token: 0x04004628 RID: 17960
		public const int SelectHintIdFieldNumber = 9;

		// Token: 0x04004629 RID: 17961
		private uint selectHintId_;
	}
}
