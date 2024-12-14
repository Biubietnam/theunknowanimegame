using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000935 RID: 2357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractChargerScRsp : IMessage<InteractChargerScRsp>, IMessage, IEquatable<InteractChargerScRsp>, IDeepCloneable<InteractChargerScRsp>, IBufferMessage
	{
		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06006927 RID: 26919 RVA: 0x00118BB3 File Offset: 0x00116DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractChargerScRsp> Parser
		{
			get
			{
				return InteractChargerScRsp._parser;
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x00118BBA File Offset: 0x00116DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InteractChargerScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06006929 RID: 26921 RVA: 0x00118BCC File Offset: 0x00116DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractChargerScRsp.Descriptor;
			}
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x00118BD3 File Offset: 0x00116DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractChargerScRsp()
		{
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00118BDC File Offset: 0x00116DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractChargerScRsp(InteractChargerScRsp other) : this()
		{
			this.chargerInfo_ = ((other.chargerInfo_ != null) ? other.chargerInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x00118C44 File Offset: 0x00116E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractChargerScRsp Clone()
		{
			return new InteractChargerScRsp(this);
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x0600692D RID: 26925 RVA: 0x00118C4C File Offset: 0x00116E4C
		// (set) Token: 0x0600692E RID: 26926 RVA: 0x00118C54 File Offset: 0x00116E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChargerInfo ChargerInfo
		{
			get
			{
				return this.chargerInfo_;
			}
			set
			{
				this.chargerInfo_ = value;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x0600692F RID: 26927 RVA: 0x00118C5D File Offset: 0x00116E5D
		// (set) Token: 0x06006930 RID: 26928 RVA: 0x00118C65 File Offset: 0x00116E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06006931 RID: 26929 RVA: 0x00118C6E File Offset: 0x00116E6E
		// (set) Token: 0x06006932 RID: 26930 RVA: 0x00118C76 File Offset: 0x00116E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterEnergyInfo EnergyInfo
		{
			get
			{
				return this.energyInfo_;
			}
			set
			{
				this.energyInfo_ = value;
			}
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x00118C7F File Offset: 0x00116E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractChargerScRsp);
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x00118C90 File Offset: 0x00116E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractChargerScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.ChargerInfo, other.ChargerInfo) && this.Retcode == other.Retcode && object.Equals(this.EnergyInfo, other.EnergyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00118CF4 File Offset: 0x00116EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chargerInfo_ != null)
			{
				num ^= this.ChargerInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.energyInfo_ != null)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00118D5F File Offset: 0x00116F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00118D67 File Offset: 0x00116F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x00118D70 File Offset: 0x00116F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this.chargerInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ChargerInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x00118DE8 File Offset: 0x00116FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chargerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChargerInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.energyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnergyInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x00118E58 File Offset: 0x00117058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractChargerScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chargerInfo_ != null)
			{
				if (this.chargerInfo_ == null)
				{
					this.ChargerInfo = new ChargerInfo();
				}
				this.ChargerInfo.MergeFrom(other.ChargerInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.energyInfo_ != null)
			{
				if (this.energyInfo_ == null)
				{
					this.EnergyInfo = new RotaterEnergyInfo();
				}
				this.EnergyInfo.MergeFrom(other.EnergyInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x00118EEC File Offset: 0x001170EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x00118EF8 File Offset: 0x001170F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 50U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						if (this.chargerInfo_ == null)
						{
							this.ChargerInfo = new ChargerInfo();
						}
						input.ReadMessage(this.ChargerInfo);
					}
				}
				else
				{
					if (this.energyInfo_ == null)
					{
						this.EnergyInfo = new RotaterEnergyInfo();
					}
					input.ReadMessage(this.EnergyInfo);
				}
			}
		}

		// Token: 0x0400284F RID: 10319
		private static readonly MessageParser<InteractChargerScRsp> _parser = new MessageParser<InteractChargerScRsp>(() => new InteractChargerScRsp());

		// Token: 0x04002850 RID: 10320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002851 RID: 10321
		public const int ChargerInfoFieldNumber = 6;

		// Token: 0x04002852 RID: 10322
		private ChargerInfo chargerInfo_;

		// Token: 0x04002853 RID: 10323
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04002854 RID: 10324
		private uint retcode_;

		// Token: 0x04002855 RID: 10325
		public const int EnergyInfoFieldNumber = 3;

		// Token: 0x04002856 RID: 10326
		private RotaterEnergyInfo energyInfo_;
	}
}
