using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C3 RID: 195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarPathChangedNotify : IMessage<AvatarPathChangedNotify>, IMessage, IEquatable<AvatarPathChangedNotify>, IDeepCloneable<AvatarPathChangedNotify>, IBufferMessage
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0001A11F File Offset: 0x0001831F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarPathChangedNotify> Parser
		{
			get
			{
				return AvatarPathChangedNotify._parser;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0001A126 File Offset: 0x00018326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarPathChangedNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0001A138 File Offset: 0x00018338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarPathChangedNotify.Descriptor;
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0001A13F File Offset: 0x0001833F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarPathChangedNotify()
		{
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0001A147 File Offset: 0x00018347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarPathChangedNotify(AvatarPathChangedNotify other) : this()
		{
			this.baseAvatarId_ = other.baseAvatarId_;
			this.curMultiPathAvatarType_ = other.curMultiPathAvatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0001A178 File Offset: 0x00018378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarPathChangedNotify Clone()
		{
			return new AvatarPathChangedNotify(this);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0001A180 File Offset: 0x00018380
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0001A188 File Offset: 0x00018388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0001A191 File Offset: 0x00018391
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0001A199 File Offset: 0x00018399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarType CurMultiPathAvatarType
		{
			get
			{
				return this.curMultiPathAvatarType_;
			}
			set
			{
				this.curMultiPathAvatarType_ = value;
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001A1A2 File Offset: 0x000183A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarPathChangedNotify);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0001A1B0 File Offset: 0x000183B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarPathChangedNotify other)
		{
			return other != null && (other == this || (this.BaseAvatarId == other.BaseAvatarId && this.CurMultiPathAvatarType == other.CurMultiPathAvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0001A1F0 File Offset: 0x000183F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.CurMultiPathAvatarType != MultiPathAvatarType.None)
			{
				num ^= this.CurMultiPathAvatarType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0001A24E File Offset: 0x0001844E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0001A256 File Offset: 0x00018456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0001A260 File Offset: 0x00018460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurMultiPathAvatarType != MultiPathAvatarType.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.CurMultiPathAvatarType);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001A2BC File Offset: 0x000184BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.CurMultiPathAvatarType != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurMultiPathAvatarType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0001A314 File Offset: 0x00018514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarPathChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.CurMultiPathAvatarType != MultiPathAvatarType.None)
			{
				this.CurMultiPathAvatarType = other.CurMultiPathAvatarType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0001A364 File Offset: 0x00018564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001A370 File Offset: 0x00018570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BaseAvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.CurMultiPathAvatarType = (MultiPathAvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04000394 RID: 916
		private static readonly MessageParser<AvatarPathChangedNotify> _parser = new MessageParser<AvatarPathChangedNotify>(() => new AvatarPathChangedNotify());

		// Token: 0x04000395 RID: 917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000396 RID: 918
		public const int BaseAvatarIdFieldNumber = 13;

		// Token: 0x04000397 RID: 919
		private uint baseAvatarId_;

		// Token: 0x04000398 RID: 920
		public const int CurMultiPathAvatarTypeFieldNumber = 4;

		// Token: 0x04000399 RID: 921
		private MultiPathAvatarType curMultiPathAvatarType_;
	}
}
