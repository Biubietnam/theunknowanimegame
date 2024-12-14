using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013EF RID: 5103
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateRedDotDataCsReq : IMessage<UpdateRedDotDataCsReq>, IMessage, IEquatable<UpdateRedDotDataCsReq>, IDeepCloneable<UpdateRedDotDataCsReq>, IBufferMessage
	{
		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x0600E380 RID: 58240 RVA: 0x0025D0CB File Offset: 0x0025B2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateRedDotDataCsReq> Parser
		{
			get
			{
				return UpdateRedDotDataCsReq._parser;
			}
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x0600E381 RID: 58241 RVA: 0x0025D0D2 File Offset: 0x0025B2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateRedDotDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x0600E382 RID: 58242 RVA: 0x0025D0E4 File Offset: 0x0025B2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRedDotDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x0025D0EB File Offset: 0x0025B2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRedDotDataCsReq()
		{
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x0025D100 File Offset: 0x0025B300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRedDotDataCsReq(UpdateRedDotDataCsReq other) : this()
		{
			this.switchList_ = other.switchList_.Clone();
			this.groupId_ = other.groupId_;
			this.panelId_ = other.panelId_;
			this.jONNHKHBKAA_ = other.jONNHKHBKAA_;
			this.aCPLFDCNGKO_ = other.aCPLFDCNGKO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E385 RID: 58245 RVA: 0x0025D165 File Offset: 0x0025B365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRedDotDataCsReq Clone()
		{
			return new UpdateRedDotDataCsReq(this);
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x0600E386 RID: 58246 RVA: 0x0025D16D File Offset: 0x0025B36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SwitchList
		{
			get
			{
				return this.switchList_;
			}
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x0600E387 RID: 58247 RVA: 0x0025D175 File Offset: 0x0025B375
		// (set) Token: 0x0600E388 RID: 58248 RVA: 0x0025D17D File Offset: 0x0025B37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x0600E389 RID: 58249 RVA: 0x0025D186 File Offset: 0x0025B386
		// (set) Token: 0x0600E38A RID: 58250 RVA: 0x0025D18E File Offset: 0x0025B38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x0600E38B RID: 58251 RVA: 0x0025D197 File Offset: 0x0025B397
		// (set) Token: 0x0600E38C RID: 58252 RVA: 0x0025D19F File Offset: 0x0025B39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IBIECKLCAAL JONNHKHBKAA
		{
			get
			{
				return this.jONNHKHBKAA_;
			}
			set
			{
				this.jONNHKHBKAA_ = value;
			}
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x0600E38D RID: 58253 RVA: 0x0025D1A8 File Offset: 0x0025B3A8
		// (set) Token: 0x0600E38E RID: 58254 RVA: 0x0025D1B0 File Offset: 0x0025B3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACPLFDCNGKO
		{
			get
			{
				return this.aCPLFDCNGKO_;
			}
			set
			{
				this.aCPLFDCNGKO_ = value;
			}
		}

		// Token: 0x0600E38F RID: 58255 RVA: 0x0025D1B9 File Offset: 0x0025B3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRedDotDataCsReq);
		}

		// Token: 0x0600E390 RID: 58256 RVA: 0x0025D1C8 File Offset: 0x0025B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateRedDotDataCsReq other)
		{
			return other != null && (other == this || (this.switchList_.Equals(other.switchList_) && this.GroupId == other.GroupId && this.PanelId == other.PanelId && this.JONNHKHBKAA == other.JONNHKHBKAA && this.ACPLFDCNGKO == other.ACPLFDCNGKO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E391 RID: 58257 RVA: 0x0025D248 File Offset: 0x0025B448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.switchList_.GetHashCode();
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.JONNHKHBKAA != IBIECKLCAAL.UpdateReddotNone)
			{
				num ^= this.JONNHKHBKAA.GetHashCode();
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				num ^= this.ACPLFDCNGKO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E392 RID: 58258 RVA: 0x0025D2E6 File Offset: 0x0025B4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E393 RID: 58259 RVA: 0x0025D2EE File Offset: 0x0025B4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E394 RID: 58260 RVA: 0x0025D2F8 File Offset: 0x0025B4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PanelId);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GroupId);
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ACPLFDCNGKO);
			}
			this.switchList_.WriteTo(ref output, UpdateRedDotDataCsReq._repeated_switchList_codec);
			if (this.JONNHKHBKAA != IBIECKLCAAL.UpdateReddotNone)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.JONNHKHBKAA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E395 RID: 58261 RVA: 0x0025D39C File Offset: 0x0025B59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.switchList_.CalculateSize(UpdateRedDotDataCsReq._repeated_switchList_codec);
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.JONNHKHBKAA != IBIECKLCAAL.UpdateReddotNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.JONNHKHBKAA);
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACPLFDCNGKO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E396 RID: 58262 RVA: 0x0025D438 File Offset: 0x0025B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateRedDotDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.switchList_.Add(other.switchList_);
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.JONNHKHBKAA != IBIECKLCAAL.UpdateReddotNone)
			{
				this.JONNHKHBKAA = other.JONNHKHBKAA;
			}
			if (other.ACPLFDCNGKO != 0U)
			{
				this.ACPLFDCNGKO = other.ACPLFDCNGKO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x0025D4C1 File Offset: 0x0025B6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x0025D4CC File Offset: 0x0025B6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ACPLFDCNGKO = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U || num == 90U)
					{
						this.switchList_.AddEntriesFrom(ref input, UpdateRedDotDataCsReq._repeated_switchList_codec);
						continue;
					}
					if (num == 104U)
					{
						this.JONNHKHBKAA = (IBIECKLCAAL)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A6A RID: 23146
		private static readonly MessageParser<UpdateRedDotDataCsReq> _parser = new MessageParser<UpdateRedDotDataCsReq>(() => new UpdateRedDotDataCsReq());

		// Token: 0x04005A6B RID: 23147
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A6C RID: 23148
		public const int SwitchListFieldNumber = 11;

		// Token: 0x04005A6D RID: 23149
		private static readonly FieldCodec<uint> _repeated_switchList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04005A6E RID: 23150
		private readonly RepeatedField<uint> switchList_ = new RepeatedField<uint>();

		// Token: 0x04005A6F RID: 23151
		public const int GroupIdFieldNumber = 7;

		// Token: 0x04005A70 RID: 23152
		private uint groupId_;

		// Token: 0x04005A71 RID: 23153
		public const int PanelIdFieldNumber = 1;

		// Token: 0x04005A72 RID: 23154
		private uint panelId_;

		// Token: 0x04005A73 RID: 23155
		public const int JONNHKHBKAAFieldNumber = 13;

		// Token: 0x04005A74 RID: 23156
		private IBIECKLCAAL jONNHKHBKAA_;

		// Token: 0x04005A75 RID: 23157
		public const int ACPLFDCNGKOFieldNumber = 9;

		// Token: 0x04005A76 RID: 23158
		private uint aCPLFDCNGKO_;
	}
}
