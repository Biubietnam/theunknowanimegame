using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E3 RID: 4579
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StopRogueAdventureRoomCsReq : IMessage<StopRogueAdventureRoomCsReq>, IMessage, IEquatable<StopRogueAdventureRoomCsReq>, IDeepCloneable<StopRogueAdventureRoomCsReq>, IBufferMessage
	{
		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600CC9D RID: 52381 RVA: 0x0022527D File Offset: 0x0022347D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StopRogueAdventureRoomCsReq> Parser
		{
			get
			{
				return StopRogueAdventureRoomCsReq._parser;
			}
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0600CC9E RID: 52382 RVA: 0x00225284 File Offset: 0x00223484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StopRogueAdventureRoomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600CC9F RID: 52383 RVA: 0x00225296 File Offset: 0x00223496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopRogueAdventureRoomCsReq.Descriptor;
			}
		}

		// Token: 0x0600CCA0 RID: 52384 RVA: 0x0022529D File Offset: 0x0022349D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopRogueAdventureRoomCsReq()
		{
		}

		// Token: 0x0600CCA1 RID: 52385 RVA: 0x002252B0 File Offset: 0x002234B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopRogueAdventureRoomCsReq(StopRogueAdventureRoomCsReq other) : this()
		{
			this.jIHALOAEMMJ_ = other.jIHALOAEMMJ_;
			this.hitTargetIndexList_ = other.hitTargetIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x002252E6 File Offset: 0x002234E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopRogueAdventureRoomCsReq Clone()
		{
			return new StopRogueAdventureRoomCsReq(this);
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600CCA3 RID: 52387 RVA: 0x002252EE File Offset: 0x002234EE
		// (set) Token: 0x0600CCA4 RID: 52388 RVA: 0x002252F6 File Offset: 0x002234F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIHALOAEMMJ
		{
			get
			{
				return this.jIHALOAEMMJ_;
			}
			set
			{
				this.jIHALOAEMMJ_ = value;
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0600CCA5 RID: 52389 RVA: 0x002252FF File Offset: 0x002234FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HitTargetIndexList
		{
			get
			{
				return this.hitTargetIndexList_;
			}
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x00225307 File Offset: 0x00223507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopRogueAdventureRoomCsReq);
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x00225318 File Offset: 0x00223518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopRogueAdventureRoomCsReq other)
		{
			return other != null && (other == this || (this.JIHALOAEMMJ == other.JIHALOAEMMJ && this.hitTargetIndexList_.Equals(other.hitTargetIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCA8 RID: 52392 RVA: 0x00225368 File Offset: 0x00223568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JIHALOAEMMJ != 0U)
			{
				num ^= this.JIHALOAEMMJ.GetHashCode();
			}
			num ^= this.hitTargetIndexList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCA9 RID: 52393 RVA: 0x002253B5 File Offset: 0x002235B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CCAA RID: 52394 RVA: 0x002253BD File Offset: 0x002235BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCAB RID: 52395 RVA: 0x002253C8 File Offset: 0x002235C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hitTargetIndexList_.WriteTo(ref output, StopRogueAdventureRoomCsReq._repeated_hitTargetIndexList_codec);
			if (this.JIHALOAEMMJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.JIHALOAEMMJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x00225418 File Offset: 0x00223618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JIHALOAEMMJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIHALOAEMMJ);
			}
			num += this.hitTargetIndexList_.CalculateSize(StopRogueAdventureRoomCsReq._repeated_hitTargetIndexList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCAD RID: 52397 RVA: 0x0022546C File Offset: 0x0022366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StopRogueAdventureRoomCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JIHALOAEMMJ != 0U)
			{
				this.JIHALOAEMMJ = other.JIHALOAEMMJ;
			}
			this.hitTargetIndexList_.Add(other.hitTargetIndexList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCAE RID: 52398 RVA: 0x002254B9 File Offset: 0x002236B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCAF RID: 52399 RVA: 0x002254C4 File Offset: 0x002236C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JIHALOAEMMJ = input.ReadUInt32();
					}
				}
				else
				{
					this.hitTargetIndexList_.AddEntriesFrom(ref input, StopRogueAdventureRoomCsReq._repeated_hitTargetIndexList_codec);
				}
			}
		}

		// Token: 0x04005283 RID: 21123
		private static readonly MessageParser<StopRogueAdventureRoomCsReq> _parser = new MessageParser<StopRogueAdventureRoomCsReq>(() => new StopRogueAdventureRoomCsReq());

		// Token: 0x04005284 RID: 21124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005285 RID: 21125
		public const int JIHALOAEMMJFieldNumber = 12;

		// Token: 0x04005286 RID: 21126
		private uint jIHALOAEMMJ_;

		// Token: 0x04005287 RID: 21127
		public const int HitTargetIndexListFieldNumber = 4;

		// Token: 0x04005288 RID: 21128
		private static readonly FieldCodec<uint> _repeated_hitTargetIndexList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04005289 RID: 21129
		private readonly RepeatedField<uint> hitTargetIndexList_ = new RepeatedField<uint>();
	}
}
