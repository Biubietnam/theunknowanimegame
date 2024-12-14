using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001277 RID: 4727
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncLineupNotify : IMessage<SyncLineupNotify>, IMessage, IEquatable<SyncLineupNotify>, IDeepCloneable<SyncLineupNotify>, IBufferMessage
	{
		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0600D2FD RID: 54013 RVA: 0x00233947 File Offset: 0x00231B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncLineupNotify> Parser
		{
			get
			{
				return SyncLineupNotify._parser;
			}
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x0023394E File Offset: 0x00231B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncLineupNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0600D2FF RID: 54015 RVA: 0x00233960 File Offset: 0x00231B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncLineupNotify.Descriptor;
			}
		}

		// Token: 0x0600D300 RID: 54016 RVA: 0x00233967 File Offset: 0x00231B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncLineupNotify()
		{
		}

		// Token: 0x0600D301 RID: 54017 RVA: 0x0023397C File Offset: 0x00231B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncLineupNotify(SyncLineupNotify other) : this()
		{
			this.reasonList_ = other.reasonList_.Clone();
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D302 RID: 54018 RVA: 0x002339CD File Offset: 0x00231BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncLineupNotify Clone()
		{
			return new SyncLineupNotify(this);
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0600D303 RID: 54019 RVA: 0x002339D5 File Offset: 0x00231BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SyncLineupReason> ReasonList
		{
			get
			{
				return this.reasonList_;
			}
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0600D304 RID: 54020 RVA: 0x002339DD File Offset: 0x00231BDD
		// (set) Token: 0x0600D305 RID: 54021 RVA: 0x002339E5 File Offset: 0x00231BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x0600D306 RID: 54022 RVA: 0x002339EE File Offset: 0x00231BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncLineupNotify);
		}

		// Token: 0x0600D307 RID: 54023 RVA: 0x002339FC File Offset: 0x00231BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncLineupNotify other)
		{
			return other != null && (other == this || (this.reasonList_.Equals(other.reasonList_) && object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x00233A50 File Offset: 0x00231C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.reasonList_.GetHashCode();
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D309 RID: 54025 RVA: 0x00233A9A File Offset: 0x00231C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D30A RID: 54026 RVA: 0x00233AA2 File Offset: 0x00231CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D30B RID: 54027 RVA: 0x00233AAC File Offset: 0x00231CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.reasonList_.WriteTo(ref output, SyncLineupNotify._repeated_reasonList_codec);
			if (this.lineup_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D30C RID: 54028 RVA: 0x00233AFC File Offset: 0x00231CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.reasonList_.CalculateSize(SyncLineupNotify._repeated_reasonList_codec);
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D30D RID: 54029 RVA: 0x00233B50 File Offset: 0x00231D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncLineupNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.reasonList_.Add(other.reasonList_);
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D30E RID: 54030 RVA: 0x00233BB5 File Offset: 0x00231DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D30F RID: 54031 RVA: 0x00233BC0 File Offset: 0x00231DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
					}
				}
				else
				{
					this.reasonList_.AddEntriesFrom(ref input, SyncLineupNotify._repeated_reasonList_codec);
				}
			}
		}

		// Token: 0x0400547E RID: 21630
		private static readonly MessageParser<SyncLineupNotify> _parser = new MessageParser<SyncLineupNotify>(() => new SyncLineupNotify());

		// Token: 0x0400547F RID: 21631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005480 RID: 21632
		public const int ReasonListFieldNumber = 1;

		// Token: 0x04005481 RID: 21633
		private static readonly FieldCodec<SyncLineupReason> _repeated_reasonList_codec = FieldCodec.ForEnum<SyncLineupReason>(10U, (SyncLineupReason x) => (int)x, (int x) => (SyncLineupReason)x);

		// Token: 0x04005482 RID: 21634
		private readonly RepeatedField<SyncLineupReason> reasonList_ = new RepeatedField<SyncLineupReason>();

		// Token: 0x04005483 RID: 21635
		public const int LineupFieldNumber = 14;

		// Token: 0x04005484 RID: 21636
		private LineupInfo lineup_;
	}
}
