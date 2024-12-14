using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200103F RID: 4159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RotateMapCsReq : IMessage<RotateMapCsReq>, IMessage, IEquatable<RotateMapCsReq>, IDeepCloneable<RotateMapCsReq>, IBufferMessage
	{
		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600B8FD RID: 47357 RVA: 0x001F0A47 File Offset: 0x001EEC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RotateMapCsReq> Parser
		{
			get
			{
				return RotateMapCsReq._parser;
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x001F0A4E File Offset: 0x001EEC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RotateMapCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600B8FF RID: 47359 RVA: 0x001F0A60 File Offset: 0x001EEC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RotateMapCsReq.Descriptor;
			}
		}

		// Token: 0x0600B900 RID: 47360 RVA: 0x001F0A67 File Offset: 0x001EEC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotateMapCsReq()
		{
		}

		// Token: 0x0600B901 RID: 47361 RVA: 0x001F0A70 File Offset: 0x001EEC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotateMapCsReq(RotateMapCsReq other) : this()
		{
			this.gMCFBLFAFFO_ = other.gMCFBLFAFFO_;
			this.groupId_ = other.groupId_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B902 RID: 47362 RVA: 0x001F0AE4 File Offset: 0x001EECE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotateMapCsReq Clone()
		{
			return new RotateMapCsReq(this);
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600B903 RID: 47363 RVA: 0x001F0AEC File Offset: 0x001EECEC
		// (set) Token: 0x0600B904 RID: 47364 RVA: 0x001F0AF4 File Offset: 0x001EECF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GMCFBLFAFFO
		{
			get
			{
				return this.gMCFBLFAFFO_;
			}
			set
			{
				this.gMCFBLFAFFO_ = value;
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600B905 RID: 47365 RVA: 0x001F0AFD File Offset: 0x001EECFD
		// (set) Token: 0x0600B906 RID: 47366 RVA: 0x001F0B05 File Offset: 0x001EED05
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

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600B907 RID: 47367 RVA: 0x001F0B0E File Offset: 0x001EED0E
		// (set) Token: 0x0600B908 RID: 47368 RVA: 0x001F0B16 File Offset: 0x001EED16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600B909 RID: 47369 RVA: 0x001F0B1F File Offset: 0x001EED1F
		// (set) Token: 0x0600B90A RID: 47370 RVA: 0x001F0B27 File Offset: 0x001EED27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMBLIADNKEO RoomMap
		{
			get
			{
				return this.roomMap_;
			}
			set
			{
				this.roomMap_ = value;
			}
		}

		// Token: 0x0600B90B RID: 47371 RVA: 0x001F0B30 File Offset: 0x001EED30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RotateMapCsReq);
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x001F0B40 File Offset: 0x001EED40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RotateMapCsReq other)
		{
			return other != null && (other == this || (this.GMCFBLFAFFO == other.GMCFBLFAFFO && this.GroupId == other.GroupId && object.Equals(this.Motion, other.Motion) && object.Equals(this.RoomMap, other.RoomMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x001F0BB4 File Offset: 0x001EEDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GMCFBLFAFFO != 0U)
			{
				num ^= this.GMCFBLFAFFO.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x001F0C38 File Offset: 0x001EEE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x001F0C40 File Offset: 0x001EEE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x001F0C4C File Offset: 0x001EEE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GMCFBLFAFFO != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GMCFBLFAFFO);
			}
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoomMap);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GroupId);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x001F0CE0 File Offset: 0x001EEEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GMCFBLFAFFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GMCFBLFAFFO);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x001F0D68 File Offset: 0x001EEF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RotateMapCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GMCFBLFAFFO != 0U)
			{
				this.GMCFBLFAFFO = other.GMCFBLFAFFO;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new HMBLIADNKEO();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x001F0E10 File Offset: 0x001EF010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x001F0E1C File Offset: 0x001EF01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 24U)
					{
						this.GMCFBLFAFFO = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.roomMap_ == null)
						{
							this.RoomMap = new HMBLIADNKEO();
						}
						input.ReadMessage(this.RoomMap);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.motion_ == null)
						{
							this.Motion = new MotionInfo();
						}
						input.ReadMessage(this.Motion);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004AF0 RID: 19184
		private static readonly MessageParser<RotateMapCsReq> _parser = new MessageParser<RotateMapCsReq>(() => new RotateMapCsReq());

		// Token: 0x04004AF1 RID: 19185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AF2 RID: 19186
		public const int GMCFBLFAFFOFieldNumber = 3;

		// Token: 0x04004AF3 RID: 19187
		private uint gMCFBLFAFFO_;

		// Token: 0x04004AF4 RID: 19188
		public const int GroupIdFieldNumber = 9;

		// Token: 0x04004AF5 RID: 19189
		private uint groupId_;

		// Token: 0x04004AF6 RID: 19190
		public const int MotionFieldNumber = 14;

		// Token: 0x04004AF7 RID: 19191
		private MotionInfo motion_;

		// Token: 0x04004AF8 RID: 19192
		public const int RoomMapFieldNumber = 7;

		// Token: 0x04004AF9 RID: 19193
		private HMBLIADNKEO roomMap_;
	}
}
