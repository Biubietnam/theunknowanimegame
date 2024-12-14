using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000937 RID: 2359
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractPropCsReq : IMessage<InteractPropCsReq>, IMessage, IEquatable<InteractPropCsReq>, IDeepCloneable<InteractPropCsReq>, IBufferMessage
	{
		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x06006940 RID: 26944 RVA: 0x0011901C File Offset: 0x0011721C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractPropCsReq> Parser
		{
			get
			{
				return InteractPropCsReq._parser;
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06006941 RID: 26945 RVA: 0x00119023 File Offset: 0x00117223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InteractPropCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06006942 RID: 26946 RVA: 0x00119035 File Offset: 0x00117235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractPropCsReq.Descriptor;
			}
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x0011903C File Offset: 0x0011723C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractPropCsReq()
		{
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00119044 File Offset: 0x00117244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractPropCsReq(InteractPropCsReq other) : this()
		{
			this.interactId_ = other.interactId_;
			this.propEntityId_ = other.propEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00119075 File Offset: 0x00117275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractPropCsReq Clone()
		{
			return new InteractPropCsReq(this);
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06006946 RID: 26950 RVA: 0x0011907D File Offset: 0x0011727D
		// (set) Token: 0x06006947 RID: 26951 RVA: 0x00119085 File Offset: 0x00117285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractId
		{
			get
			{
				return this.interactId_;
			}
			set
			{
				this.interactId_ = value;
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06006948 RID: 26952 RVA: 0x0011908E File Offset: 0x0011728E
		// (set) Token: 0x06006949 RID: 26953 RVA: 0x00119096 File Offset: 0x00117296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x0011909F File Offset: 0x0011729F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractPropCsReq);
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x001190AD File Offset: 0x001172AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractPropCsReq other)
		{
			return other != null && (other == this || (this.InteractId == other.InteractId && this.PropEntityId == other.PropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x001190EC File Offset: 0x001172EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractId != 0U)
			{
				num ^= this.InteractId.GetHashCode();
			}
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00119144 File Offset: 0x00117344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x0011914C File Offset: 0x0011734C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00119158 File Offset: 0x00117358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.InteractId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.InteractId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x001191B4 File Offset: 0x001173B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractId);
			}
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x0011920C File Offset: 0x0011740C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractPropCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractId != 0U)
			{
				this.InteractId = other.InteractId;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x0011925C File Offset: 0x0011745C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00119268 File Offset: 0x00117468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractId = input.ReadUInt32();
					}
				}
				else
				{
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002858 RID: 10328
		private static readonly MessageParser<InteractPropCsReq> _parser = new MessageParser<InteractPropCsReq>(() => new InteractPropCsReq());

		// Token: 0x04002859 RID: 10329
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400285A RID: 10330
		public const int InteractIdFieldNumber = 3;

		// Token: 0x0400285B RID: 10331
		private uint interactId_;

		// Token: 0x0400285C RID: 10332
		public const int PropEntityIdFieldNumber = 2;

		// Token: 0x0400285D RID: 10333
		private uint propEntityId_;
	}
}
