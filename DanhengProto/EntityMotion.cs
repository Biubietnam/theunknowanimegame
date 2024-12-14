using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200048B RID: 1163
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityMotion : IMessage<EntityMotion>, IMessage, IEquatable<EntityMotion>, IDeepCloneable<EntityMotion>, IBufferMessage
	{
		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x0008E49F File Offset: 0x0008C69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityMotion> Parser
		{
			get
			{
				return EntityMotion._parser;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x0008E4A6 File Offset: 0x0008C6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityMotionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x0008E4B8 File Offset: 0x0008C6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityMotion.Descriptor;
			}
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x0008E4BF File Offset: 0x0008C6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotion()
		{
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x0008E4C8 File Offset: 0x0008C6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotion(EntityMotion other) : this()
		{
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.dOOCFNPJGND_ = other.dOOCFNPJGND_;
			this.entityId_ = other.entityId_;
			this.mapLayer_ = other.mapLayer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x0008E52C File Offset: 0x0008C72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotion Clone()
		{
			return new EntityMotion(this);
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x0008E534 File Offset: 0x0008C734
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x0008E53C File Offset: 0x0008C73C
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

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x0008E545 File Offset: 0x0008C745
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x0008E54D File Offset: 0x0008C74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DOOCFNPJGND
		{
			get
			{
				return this.dOOCFNPJGND_;
			}
			set
			{
				this.dOOCFNPJGND_ = value;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x0008E556 File Offset: 0x0008C756
		// (set) Token: 0x060033D9 RID: 13273 RVA: 0x0008E55E File Offset: 0x0008C75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x0008E567 File Offset: 0x0008C767
		// (set) Token: 0x060033DB RID: 13275 RVA: 0x0008E56F File Offset: 0x0008C76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapLayer
		{
			get
			{
				return this.mapLayer_;
			}
			set
			{
				this.mapLayer_ = value;
			}
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x0008E578 File Offset: 0x0008C778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityMotion);
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x0008E588 File Offset: 0x0008C788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityMotion other)
		{
			return other != null && (other == this || (object.Equals(this.Motion, other.Motion) && this.DOOCFNPJGND == other.DOOCFNPJGND && this.EntityId == other.EntityId && this.MapLayer == other.MapLayer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x0008E5F8 File Offset: 0x0008C7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.DOOCFNPJGND)
			{
				num ^= this.DOOCFNPJGND.GetHashCode();
			}
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.MapLayer != 0U)
			{
				num ^= this.MapLayer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0008E67F File Offset: 0x0008C87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0008E687 File Offset: 0x0008C887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x0008E690 File Offset: 0x0008C890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapLayer != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MapLayer);
			}
			if (this.DOOCFNPJGND)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.DOOCFNPJGND);
			}
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EntityId);
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

		// Token: 0x060033E2 RID: 13282 RVA: 0x0008E724 File Offset: 0x0008C924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.DOOCFNPJGND)
			{
				num += 2;
			}
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.MapLayer != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapLayer);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x0008E7A0 File Offset: 0x0008C9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityMotion other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.DOOCFNPJGND)
			{
				this.DOOCFNPJGND = other.DOOCFNPJGND;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.MapLayer != 0U)
			{
				this.MapLayer = other.MapLayer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x0008E830 File Offset: 0x0008CA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x0008E83C File Offset: 0x0008CA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 64U)
					{
						this.MapLayer = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.DOOCFNPJGND = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EntityId = input.ReadUInt32();
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

		// Token: 0x04001490 RID: 5264
		private static readonly MessageParser<EntityMotion> _parser = new MessageParser<EntityMotion>(() => new EntityMotion());

		// Token: 0x04001491 RID: 5265
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001492 RID: 5266
		public const int MotionFieldNumber = 14;

		// Token: 0x04001493 RID: 5267
		private MotionInfo motion_;

		// Token: 0x04001494 RID: 5268
		public const int DOOCFNPJGNDFieldNumber = 9;

		// Token: 0x04001495 RID: 5269
		private bool dOOCFNPJGND_;

		// Token: 0x04001496 RID: 5270
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04001497 RID: 5271
		private uint entityId_;

		// Token: 0x04001498 RID: 5272
		public const int MapLayerFieldNumber = 8;

		// Token: 0x04001499 RID: 5273
		private uint mapLayer_;
	}
}
