using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001133 RID: 4403
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetSpringRecoverConfigCsReq : IMessage<SetSpringRecoverConfigCsReq>, IMessage, IEquatable<SetSpringRecoverConfigCsReq>, IDeepCloneable<SetSpringRecoverConfigCsReq>, IBufferMessage
	{
		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600C459 RID: 50265 RVA: 0x0020F0D3 File Offset: 0x0020D2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetSpringRecoverConfigCsReq> Parser
		{
			get
			{
				return SetSpringRecoverConfigCsReq._parser;
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600C45A RID: 50266 RVA: 0x0020F0DA File Offset: 0x0020D2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetSpringRecoverConfigCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600C45B RID: 50267 RVA: 0x0020F0EC File Offset: 0x0020D2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetSpringRecoverConfigCsReq.Descriptor;
			}
		}

		// Token: 0x0600C45C RID: 50268 RVA: 0x0020F0F3 File Offset: 0x0020D2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSpringRecoverConfigCsReq()
		{
		}

		// Token: 0x0600C45D RID: 50269 RVA: 0x0020F0FB File Offset: 0x0020D2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSpringRecoverConfigCsReq(SetSpringRecoverConfigCsReq other) : this()
		{
			this.springRecoverConfig_ = ((other.springRecoverConfig_ != null) ? other.springRecoverConfig_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C45E RID: 50270 RVA: 0x0020F130 File Offset: 0x0020D330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSpringRecoverConfigCsReq Clone()
		{
			return new SetSpringRecoverConfigCsReq(this);
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600C45F RID: 50271 RVA: 0x0020F138 File Offset: 0x0020D338
		// (set) Token: 0x0600C460 RID: 50272 RVA: 0x0020F140 File Offset: 0x0020D340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverConfig SpringRecoverConfig
		{
			get
			{
				return this.springRecoverConfig_;
			}
			set
			{
				this.springRecoverConfig_ = value;
			}
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x0020F149 File Offset: 0x0020D349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetSpringRecoverConfigCsReq);
		}

		// Token: 0x0600C462 RID: 50274 RVA: 0x0020F157 File Offset: 0x0020D357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetSpringRecoverConfigCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.SpringRecoverConfig, other.SpringRecoverConfig) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C463 RID: 50275 RVA: 0x0020F18C File Offset: 0x0020D38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.springRecoverConfig_ != null)
			{
				num ^= this.SpringRecoverConfig.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C464 RID: 50276 RVA: 0x0020F1C8 File Offset: 0x0020D3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C465 RID: 50277 RVA: 0x0020F1D0 File Offset: 0x0020D3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C466 RID: 50278 RVA: 0x0020F1D9 File Offset: 0x0020D3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.springRecoverConfig_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SpringRecoverConfig);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C467 RID: 50279 RVA: 0x0020F20C File Offset: 0x0020D40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.springRecoverConfig_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpringRecoverConfig);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C468 RID: 50280 RVA: 0x0020F24C File Offset: 0x0020D44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetSpringRecoverConfigCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.springRecoverConfig_ != null)
			{
				if (this.springRecoverConfig_ == null)
				{
					this.SpringRecoverConfig = new SpringRecoverConfig();
				}
				this.SpringRecoverConfig.MergeFrom(other.SpringRecoverConfig);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C469 RID: 50281 RVA: 0x0020F2A0 File Offset: 0x0020D4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x0020F2AC File Offset: 0x0020D4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.springRecoverConfig_ == null)
					{
						this.SpringRecoverConfig = new SpringRecoverConfig();
					}
					input.ReadMessage(this.SpringRecoverConfig);
				}
			}
		}

		// Token: 0x04004F58 RID: 20312
		private static readonly MessageParser<SetSpringRecoverConfigCsReq> _parser = new MessageParser<SetSpringRecoverConfigCsReq>(() => new SetSpringRecoverConfigCsReq());

		// Token: 0x04004F59 RID: 20313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F5A RID: 20314
		public const int SpringRecoverConfigFieldNumber = 1;

		// Token: 0x04004F5B RID: 20315
		private SpringRecoverConfig springRecoverConfig_;
	}
}
