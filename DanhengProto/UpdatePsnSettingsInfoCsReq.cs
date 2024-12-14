using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013EB RID: 5099
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdatePsnSettingsInfoCsReq : IMessage<UpdatePsnSettingsInfoCsReq>, IMessage, IEquatable<UpdatePsnSettingsInfoCsReq>, IDeepCloneable<UpdatePsnSettingsInfoCsReq>, IBufferMessage
	{
		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x0600E354 RID: 58196 RVA: 0x0025CA43 File Offset: 0x0025AC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdatePsnSettingsInfoCsReq> Parser
		{
			get
			{
				return UpdatePsnSettingsInfoCsReq._parser;
			}
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x0600E355 RID: 58197 RVA: 0x0025CA4A File Offset: 0x0025AC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdatePsnSettingsInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x0600E356 RID: 58198 RVA: 0x0025CA5C File Offset: 0x0025AC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePsnSettingsInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600E357 RID: 58199 RVA: 0x0025CA63 File Offset: 0x0025AC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePsnSettingsInfoCsReq()
		{
		}

		// Token: 0x0600E358 RID: 58200 RVA: 0x0025CA6C File Offset: 0x0025AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePsnSettingsInfoCsReq(UpdatePsnSettingsInfoCsReq other) : this()
		{
			this.cBIONLOHECO_ = ((other.cBIONLOHECO_ != null) ? other.cBIONLOHECO_.Clone() : null);
			this.mCAJLEBOKOI_ = ((other.mCAJLEBOKOI_ != null) ? other.mCAJLEBOKOI_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E359 RID: 58201 RVA: 0x0025CAC8 File Offset: 0x0025ACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePsnSettingsInfoCsReq Clone()
		{
			return new UpdatePsnSettingsInfoCsReq(this);
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x0600E35A RID: 58202 RVA: 0x0025CAD0 File Offset: 0x0025ACD0
		// (set) Token: 0x0600E35B RID: 58203 RVA: 0x0025CAD8 File Offset: 0x0025ACD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LODLBMPAHKB CBIONLOHECO
		{
			get
			{
				return this.cBIONLOHECO_;
			}
			set
			{
				this.cBIONLOHECO_ = value;
			}
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x0600E35C RID: 58204 RVA: 0x0025CAE1 File Offset: 0x0025ACE1
		// (set) Token: 0x0600E35D RID: 58205 RVA: 0x0025CAE9 File Offset: 0x0025ACE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPPECDLFCEE MCAJLEBOKOI
		{
			get
			{
				return this.mCAJLEBOKOI_;
			}
			set
			{
				this.mCAJLEBOKOI_ = value;
			}
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x0025CAF2 File Offset: 0x0025ACF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePsnSettingsInfoCsReq);
		}

		// Token: 0x0600E35F RID: 58207 RVA: 0x0025CB00 File Offset: 0x0025AD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePsnSettingsInfoCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.CBIONLOHECO, other.CBIONLOHECO) && object.Equals(this.MCAJLEBOKOI, other.MCAJLEBOKOI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E360 RID: 58208 RVA: 0x0025CB54 File Offset: 0x0025AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cBIONLOHECO_ != null)
			{
				num ^= this.CBIONLOHECO.GetHashCode();
			}
			if (this.mCAJLEBOKOI_ != null)
			{
				num ^= this.MCAJLEBOKOI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x0025CBA6 File Offset: 0x0025ADA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E362 RID: 58210 RVA: 0x0025CBAE File Offset: 0x0025ADAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E363 RID: 58211 RVA: 0x0025CBB8 File Offset: 0x0025ADB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mCAJLEBOKOI_ != null)
			{
				output.WriteRawTag(186, 36);
				output.WriteMessage(this.MCAJLEBOKOI);
			}
			if (this.cBIONLOHECO_ != null)
			{
				output.WriteRawTag(210, 80);
				output.WriteMessage(this.CBIONLOHECO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E364 RID: 58212 RVA: 0x0025CC1C File Offset: 0x0025AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cBIONLOHECO_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CBIONLOHECO);
			}
			if (this.mCAJLEBOKOI_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MCAJLEBOKOI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x0025CC74 File Offset: 0x0025AE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePsnSettingsInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cBIONLOHECO_ != null)
			{
				if (this.cBIONLOHECO_ == null)
				{
					this.CBIONLOHECO = new LODLBMPAHKB();
				}
				this.CBIONLOHECO.MergeFrom(other.CBIONLOHECO);
			}
			if (other.mCAJLEBOKOI_ != null)
			{
				if (this.mCAJLEBOKOI_ == null)
				{
					this.MCAJLEBOKOI = new JPPECDLFCEE();
				}
				this.MCAJLEBOKOI.MergeFrom(other.MCAJLEBOKOI);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E366 RID: 58214 RVA: 0x0025CCF4 File Offset: 0x0025AEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E367 RID: 58215 RVA: 0x0025CD00 File Offset: 0x0025AF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 4666U)
				{
					if (num != 10322U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.cBIONLOHECO_ == null)
						{
							this.CBIONLOHECO = new LODLBMPAHKB();
						}
						input.ReadMessage(this.CBIONLOHECO);
					}
				}
				else
				{
					if (this.mCAJLEBOKOI_ == null)
					{
						this.MCAJLEBOKOI = new JPPECDLFCEE();
					}
					input.ReadMessage(this.MCAJLEBOKOI);
				}
			}
		}

		// Token: 0x04005A5E RID: 23134
		private static readonly MessageParser<UpdatePsnSettingsInfoCsReq> _parser = new MessageParser<UpdatePsnSettingsInfoCsReq>(() => new UpdatePsnSettingsInfoCsReq());

		// Token: 0x04005A5F RID: 23135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A60 RID: 23136
		public const int CBIONLOHECOFieldNumber = 1290;

		// Token: 0x04005A61 RID: 23137
		private LODLBMPAHKB cBIONLOHECO_;

		// Token: 0x04005A62 RID: 23138
		public const int MCAJLEBOKOIFieldNumber = 583;

		// Token: 0x04005A63 RID: 23139
		private JPPECDLFCEE mCAJLEBOKOI_;
	}
}
