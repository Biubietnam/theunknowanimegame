using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000419 RID: 1049
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ENCGLEPGAGE : IMessage<ENCGLEPGAGE>, IMessage, IEquatable<ENCGLEPGAGE>, IDeepCloneable<ENCGLEPGAGE>, IBufferMessage
	{
		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002E92 RID: 11922 RVA: 0x00080973 File Offset: 0x0007EB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ENCGLEPGAGE> Parser
		{
			get
			{
				return ENCGLEPGAGE._parser;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x0008097A File Offset: 0x0007EB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ENCGLEPGAGEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x0008098C File Offset: 0x0007EB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ENCGLEPGAGE.Descriptor;
			}
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00080993 File Offset: 0x0007EB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENCGLEPGAGE()
		{
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x0008099C File Offset: 0x0007EB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENCGLEPGAGE(ENCGLEPGAGE other) : this()
		{
			this.oLHEALPEOEA_ = ((other.oLHEALPEOEA_ != null) ? other.oLHEALPEOEA_.Clone() : null);
			this.fUNCUNLOCKIDEQUIPMENT_ = ((other.fUNCUNLOCKIDEQUIPMENT_ != null) ? other.fUNCUNLOCKIDEQUIPMENT_.Clone() : null);
			this.fUNCUNLOCKIDRELIC_ = ((other.fUNCUNLOCKIDRELIC_ != null) ? other.fUNCUNLOCKIDRELIC_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00080A14 File Offset: 0x0007EC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENCGLEPGAGE Clone()
		{
			return new ENCGLEPGAGE(this);
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x00080A1C File Offset: 0x0007EC1C
		// (set) Token: 0x06002E99 RID: 11929 RVA: 0x00080A24 File Offset: 0x0007EC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGMOBALEOHO OLHEALPEOEA
		{
			get
			{
				return this.oLHEALPEOEA_;
			}
			set
			{
				this.oLHEALPEOEA_ = value;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x00080A2D File Offset: 0x0007EC2D
		// (set) Token: 0x06002E9B RID: 11931 RVA: 0x00080A35 File Offset: 0x0007EC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEBJHOPBGAM FUNCUNLOCKIDEQUIPMENT
		{
			get
			{
				return this.fUNCUNLOCKIDEQUIPMENT_;
			}
			set
			{
				this.fUNCUNLOCKIDEQUIPMENT_ = value;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x00080A3E File Offset: 0x0007EC3E
		// (set) Token: 0x06002E9D RID: 11933 RVA: 0x00080A46 File Offset: 0x0007EC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKCIHJIHBAN FUNCUNLOCKIDRELIC
		{
			get
			{
				return this.fUNCUNLOCKIDRELIC_;
			}
			set
			{
				this.fUNCUNLOCKIDRELIC_ = value;
			}
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00080A4F File Offset: 0x0007EC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ENCGLEPGAGE);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00080A60 File Offset: 0x0007EC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ENCGLEPGAGE other)
		{
			return other != null && (other == this || (object.Equals(this.OLHEALPEOEA, other.OLHEALPEOEA) && object.Equals(this.FUNCUNLOCKIDEQUIPMENT, other.FUNCUNLOCKIDEQUIPMENT) && object.Equals(this.FUNCUNLOCKIDRELIC, other.FUNCUNLOCKIDRELIC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00080AC8 File Offset: 0x0007ECC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.oLHEALPEOEA_ != null)
			{
				num ^= this.OLHEALPEOEA.GetHashCode();
			}
			if (this.fUNCUNLOCKIDEQUIPMENT_ != null)
			{
				num ^= this.FUNCUNLOCKIDEQUIPMENT.GetHashCode();
			}
			if (this.fUNCUNLOCKIDRELIC_ != null)
			{
				num ^= this.FUNCUNLOCKIDRELIC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00080B30 File Offset: 0x0007ED30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00080B38 File Offset: 0x0007ED38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00080B44 File Offset: 0x0007ED44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fUNCUNLOCKIDRELIC_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FUNCUNLOCKIDRELIC);
			}
			if (this.fUNCUNLOCKIDEQUIPMENT_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FUNCUNLOCKIDEQUIPMENT);
			}
			if (this.oLHEALPEOEA_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.OLHEALPEOEA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00080BBC File Offset: 0x0007EDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.oLHEALPEOEA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OLHEALPEOEA);
			}
			if (this.fUNCUNLOCKIDEQUIPMENT_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FUNCUNLOCKIDEQUIPMENT);
			}
			if (this.fUNCUNLOCKIDRELIC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FUNCUNLOCKIDRELIC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00080C2C File Offset: 0x0007EE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ENCGLEPGAGE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.oLHEALPEOEA_ != null)
			{
				if (this.oLHEALPEOEA_ == null)
				{
					this.OLHEALPEOEA = new HGMOBALEOHO();
				}
				this.OLHEALPEOEA.MergeFrom(other.OLHEALPEOEA);
			}
			if (other.fUNCUNLOCKIDEQUIPMENT_ != null)
			{
				if (this.fUNCUNLOCKIDEQUIPMENT_ == null)
				{
					this.FUNCUNLOCKIDEQUIPMENT = new OEBJHOPBGAM();
				}
				this.FUNCUNLOCKIDEQUIPMENT.MergeFrom(other.FUNCUNLOCKIDEQUIPMENT);
			}
			if (other.fUNCUNLOCKIDRELIC_ != null)
			{
				if (this.fUNCUNLOCKIDRELIC_ == null)
				{
					this.FUNCUNLOCKIDRELIC = new OKCIHJIHBAN();
				}
				this.FUNCUNLOCKIDRELIC.MergeFrom(other.FUNCUNLOCKIDRELIC);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00080CD8 File Offset: 0x0007EED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00080CE4 File Offset: 0x0007EEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 66U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.oLHEALPEOEA_ == null)
							{
								this.OLHEALPEOEA = new HGMOBALEOHO();
							}
							input.ReadMessage(this.OLHEALPEOEA);
						}
					}
					else
					{
						if (this.fUNCUNLOCKIDEQUIPMENT_ == null)
						{
							this.FUNCUNLOCKIDEQUIPMENT = new OEBJHOPBGAM();
						}
						input.ReadMessage(this.FUNCUNLOCKIDEQUIPMENT);
					}
				}
				else
				{
					if (this.fUNCUNLOCKIDRELIC_ == null)
					{
						this.FUNCUNLOCKIDRELIC = new OKCIHJIHBAN();
					}
					input.ReadMessage(this.FUNCUNLOCKIDRELIC);
				}
			}
		}

		// Token: 0x040012AF RID: 4783
		private static readonly MessageParser<ENCGLEPGAGE> _parser = new MessageParser<ENCGLEPGAGE>(() => new ENCGLEPGAGE());

		// Token: 0x040012B0 RID: 4784
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012B1 RID: 4785
		public const int OLHEALPEOEAFieldNumber = 14;

		// Token: 0x040012B2 RID: 4786
		private HGMOBALEOHO oLHEALPEOEA_;

		// Token: 0x040012B3 RID: 4787
		public const int FUNCUNLOCKIDEQUIPMENTFieldNumber = 8;

		// Token: 0x040012B4 RID: 4788
		private OEBJHOPBGAM fUNCUNLOCKIDEQUIPMENT_;

		// Token: 0x040012B5 RID: 4789
		public const int FUNCUNLOCKIDRELICFieldNumber = 6;

		// Token: 0x040012B6 RID: 4790
		private OKCIHJIHBAN fUNCUNLOCKIDRELIC_;
	}
}
